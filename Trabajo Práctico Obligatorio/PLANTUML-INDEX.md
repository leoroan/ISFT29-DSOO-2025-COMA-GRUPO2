# Índice de Diagramas PlantUML

Este directorio contiene los siguientes diagramas PlantUML para el sistema de biblioteca:

## Diagramas Disponibles

| Archivo PlantUML | Imagen PNG | Tipo de Diagrama | Descripción |
|------------------|------------|------------------|-------------|
| `class-diagram.puml` | `BibliotecaClassDiagram.png` | Diagrama de Clases | Estructura completa del sistema con clases, atributos, métodos y relaciones |
| `sequence-prestar-libro.puml` | `PrestarLibroSequence.png` | Diagrama de Secuencia | Flujo de interacciones para el préstamo de libros |
| `sequence-devolver-libro.puml` | `DevolverLibroSequence.png` | Diagrama de Secuencia | Flujo de interacciones para la devolución de libros |
| `activity-prestamo-libro.puml` | `PrestamoLibroActivity.png` | Diagrama de Actividad | Proceso de negocio para el préstamo de libros con decisiones |
| `use-case-diagram.puml` | `BibliotecaUseCases.png` | Diagrama de Casos de Uso | Funcionalidades del sistema desde perspectiva de usuarios |
| `state-libro-diagram.puml` | `LibroStateDiagram.png` | Diagrama de Estados | Ciclo de vida de un libro en el sistema |

## Cómo visualizar

### Opción 1: Ver imágenes PNG generadas
Las imágenes PNG ya están incluidas en este directorio y se pueden visualizar directamente desde cualquier navegador o visor de imágenes.

### Opción 2: Editar y visualizar código PlantUML
1. **Online**: Copia el contenido de cualquier archivo .puml en [PlantUML Online](http://www.plantuml.com/plantuml/uml/)

2. **Localmente**: 
   - Instala PlantUML o usa una extensión de VS Code
   - Abre los archivos .puml directamente

3. **Generar nuevas imágenes**:
   ```bash
   java -jar plantuml.jar *.puml
   ```

## Documentación completa

Ver `PLANTUML-README.md` para descripción detallada de cada diagrama.