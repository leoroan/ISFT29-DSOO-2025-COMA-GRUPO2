# Diagramas PlantUML - Sistema de Biblioteca

Este documento contiene los diagramas PlantUML para el sistema de biblioteca desarrollado como parte del Trabajo Práctico Obligatorio.

## Archivos de Diagramas

### 1. Diagrama de Clases (`class-diagram.puml`)
**Propósito**: Muestra la estructura estática del sistema, incluyendo todas las clases, sus atributos, métodos y relaciones.

**Clases incluidas:**
- `Biblioteca`: Clase principal que gestiona libros y lectores
- `Libro`: Representa un libro con título, autor y estado de préstamo
- `Lector`: Representa un lector con nombre, DNI y libros prestados
- `Program`: Clase principal con el método Main para testing

**Relaciones importantes:**
- Biblioteca contiene múltiples Libros y Lectores (composición)
- Lector puede tener hasta 3 Libros prestados (agregación)

### 2. Diagrama de Secuencia - Préstamo (`sequence-prestar-libro.puml`)
**Propósito**: Muestra la interacción entre objetos durante el proceso de préstamo de un libro.

**Flujo principal:**
1. Búsqueda del lector por nombre
2. Búsqueda del libro por título
3. Verificación de disponibilidad del libro
4. Verificación del límite de préstamos del lector
5. Ejecución del préstamo si todas las condiciones se cumplen

### 3. Diagrama de Secuencia - Devolución (`sequence-devolver-libro.puml`)
**Propósito**: Muestra la interacción entre objetos durante el proceso de devolución de un libro.

**Flujo principal:**
1. Búsqueda del libro por título
2. Identificación del lector que tiene el libro prestado
3. Verificación del estado de préstamo
4. Ejecución de la devolución si las condiciones se cumplen

### 4. Diagrama de Actividad (`activity-prestamo-libro.puml`)
**Propósito**: Muestra el flujo de trabajo y las decisiones en el proceso de préstamo de libros.

**Decisiones clave:**
- Verificación de existencia del lector
- Verificación de disponibilidad del libro
- Verificación del límite de préstamos (máximo 3)

**Resultados posibles:**
- "PRESTAMO EXITOSO"
- "LECTOR INEXISTENTE"
- "LIBRO INEXISTENTE"
- "TOPE DE PRESTAMO ALCANZADO"

### 5. Diagrama de Casos de Uso (`use-case-diagram.puml`)
**Propósito**: Muestra las funcionalidades del sistema desde la perspectiva de los usuarios.

**Actores:**
- **Bibliotecario**: Puede gestionar libros y lectores, realizar préstamos y devoluciones
- **Lector**: Puede buscar libros y consultar sus libros prestados

**Casos de uso principales:**
- Gestión de libros (agregar, buscar, remover)
- Gestión de lectores (agregar, buscar, remover)
- Operaciones de préstamo y devolución

### 6. Diagrama de Estados - Libro (`state-libro-diagram.puml`)
**Propósito**: Muestra los diferentes estados por los que puede pasar un libro durante su ciclo de vida.

**Estados principales:**
- **Creado**: Estado inicial cuando se instancia un libro
- **Disponible**: Libro está en la biblioteca y puede ser prestado
- **Prestado**: Libro está con un lector y no disponible para otros

**Transiciones:**
- Creado → Disponible: Cuando se agrega a la biblioteca
- Disponible ↔ Prestado: Mediante operaciones de préstamo y devolución

## Cómo usar estos diagramas

### Visualización
Para visualizar estos diagramas, puedes usar:
1. **PlantUML Online Server**: http://www.plantuml.com/plantuml/uml/
2. **VS Code con extensión PlantUML**
3. **IntelliJ IDEA con plugin PlantUML**
4. **Eclipse con plugin PlantUML**

### Generación de imágenes
```bash
# Usando PlantUML jar
java -jar plantuml.jar *.puml

# Usando Docker
docker run --rm -v $(pwd):/data plantuml/plantuml *.puml
```

## Notas importantes

- El sistema implementa la regla de negocio de máximo 3 libros prestados por lector
- Los diagramas reflejan el código actual implementado en C#
- Se incluyen validaciones para evitar préstamos duplicados y devoluciones inválidas
- La arquitectura permite fácil extensión para nuevas funcionalidades

## Correspondencia con el código

Cada diagrama está diseñado para reflejar fielmente la implementación en C#:
- Los métodos y propiedades corresponden exactamente a los del código
- Las relaciones mostradas son las implementadas mediante listas y referencias
- Los flujos de secuencia siguen la lógica implementada en los métodos

## Autor
Creado como parte del Trabajo Práctico Obligatorio - ISFT29 DSOO 2025