# Sistema de Administración de Club Deportivo

## Procesos del Sistema
1. **Registro de Socios**  
2. **Registro de No Socios**  
3. **Cobro de Cuotas Mensuales/Diarias**  
4. **Generación de Listado Diario de Socios con Cuota Vencida**  

---

## Clases y Atributos

### Persona
- `nombre`: Nombre del socio  
- `apellido`: Apellido del socio  
- `fecha_nacimiento`: Fecha de nacimiento  
- `direccion`: Dirección  
- `telefono`: Número de teléfono  
- `AptoFisico` : boolean
+ `Registrar`() : Persona 

### Socio
- `fecha_inscripcion`: Fecha de inscripción  
- `fecha_vencimiento_cuota`: Fecha de vencimiento de la cuota  
- `estado`: Estado (`activo`/`inactivo`)  
- `carnet_numero`: Número de carné  

### NoSocio
- `carnet_temporal`: Número de carné temporal  
+ `pagar_actividad(): Pago`: Monto pagado por el día  

### Actividad
- `nombre`: Nombre de la actividad  
- `valor`: monto del valor de la actiidad  

### Cuota
- `monto`: Monto de la cuota  
- `fecha_vencimiento`: Fecha de vencimiento  
- `fecha_pago`: Fecha de pago  
- `estado`: Estado (`pendiente`, `pagado`, `vencido`)  .

### PagoEventual
- `fecha`: Fecha del pago eventual  
- `monto`: Monto abonado  
- `medio`: Medio de pago utilizado (efectivo, tarjeta, etc.)  

---

## Funcionamiento de los Procesos

### 1. Registro de Socios
- **Flujo**:  
  1. El usuario ingresa datos personales (nombre, apellido, fecha de nacimiento, dirección, etc...).  
  2. El sistema genera un carnét único y registra la fecha de inscripción.  
  3. Se calcula la fecha de vencimiento de la cuota (30 días desde la inscripción).  
  4. Se registra el pago inicial de la cuota mensual.  
  5. El estado del socio se establece como `activo`.  
- **Regla clave**:  
  > *"Si el socio no paga antes de la fecha de vencimiento, su estado cambia a `inactivo` y pierde acceso a las actividades hasta regularizar su pago."*

### 2. Registro de No Socios
- **Flujo**:  
  1. El usuario ingresa datos personales (nombre, apellido, fecha de nacimiento, dirección, etc...).   
  2. Se cobra una tarifa fija por actividad.  
  3. El sistema genera un carnét único.  
- **Regla clave**:  
  > *"Los no socios solo pueden acceder al club el día de su registro. No requieren pago mensual ni renovación."*

### 3. Cobro de Cuotas Mensuales/Diarias
- **Para socios**:  
  - Al vencer la cuota, el sistema marca el estado como `inactivo`.  
  - Al realizar el pago, la nueva fecha de vencimiento se calcula **desde el día siguiente al vencimiento original** (ej: si venció el 1° de abril, al pagar el 5°, la nueva fecha es 5° + 30 días).  
  - El estado vuelve a `activo` y se registra el pago en la tabla `Cuota`.  
- **Para no socios**:  
  - Solo se cobra el monto diario en el momento del acceso.  
  - No hay renovación ni seguimiento posterior.  

### 4. Generación de Listado Diario de Socios con Cuota Vencida
- **Flujo**:  
  1. Cada día a medianoche, el sistema ejecuta una consulta 
  2. El listado incluye: nombre, carné, fecha de vencimiento y estado.  
- **Uso**:  
  > *"Permite al personal identificar rápidamente a los socios que deben regularizar su pago para reactivar su acceso."*

---

## Boceto de Pantallas

### 1. Pantalla de Registro de Socios
```markdown
+-------------------------------------+
| REGISTRO DE SOCIOS                  |
+-------------------------------------+
| Nombre: [__________]                |
| Apellido: [__________]              |
| Fecha Nacimiento: [__/__/__]        |
| Dirección: [__________]             |
| Teléfono: [__________]              |
| Apto Físico: [✔] [ ]                |
|                                     |
| [REGISTRAR SOCIO]                   |
+-------------------------------------+
| RESULTADO                           |
| Carnet N°: S-00123                  |
| Cuotas Generadas: 12 meses          |
| Primer Vencimiento: 2024-05-01      |
+-------------------------------------+
```

### 2. Pantalla de Registro de No Socios
```markdown
+-------------------------------------+
| REGISTRO DE NO SOCIOS               |
+-------------------------------------+
| Nombre: [__________]                |
| Apellido: [__________]              |
| Teléfono: [__________]              |
|                                     |
| [GENERAR CARNET TEMPORAL]           |
+-------------------------------------+
| RESULTADO                           |
| Carnet Temporal: T-98765            |
| Válido hasta: 2024-04-10 23:59      |
| Monto Diario: $30                   |
+-------------------------------------+
```

### 3. Pantalla de Cobro de Cuotas
```markdown
+-------------------------------------+
| COBRO DE CUOTAS                     |
+-------------------------------------+
| Buscar Socio: [__________] [BUSCAR] |
+-------------------------------------+
| Socio: Juan Pérez                   |
| Carnet: 12345                       |
| Vencimiento: 2024-04-10             |
| Estado: VENCIDO                     |
|                                     |
| Monto a Pagar: $500                 |
|                                     |
| [PAGAR CUOTA]                       |
+-------------------------------------+
```

### 4. Pantalla de Listado Diario de Cuotas Vencidas
```markdown
+-------------------------------------+
| LISTADO DIARIO DE CUOTAS VENCIDAS   |
+-------------------------------------+
| Fecha: 2024-04-10                   |
+----------------+----------+--------+
| Nombre         | Carnet   | Vencimiento | Monto |
+----------------+----------+-----------+-------+
| Juan Pérez     | S-00123  | 2024-04-01 | $500  |
| María López    | S-00456  | 2024-03-15 | $500  |
| Carlos Ruiz    | S-00789  | 2024-04-05 | $500  |
+----------------+----------+-----------+-------+
| [ACTUALIZAR LISTADO]                |
+-------------------------------------+
```