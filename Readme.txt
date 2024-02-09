Visión General
OAA Pack es una herramienta de software especializada creada por Pere Guerra (Observatori Astronòmic Albanyà) diseñada para la compresión y descompresión de archivos FIT, ofreciendo una interfaz gráfica amigable al usuario. Utiliza el poder de las utilidades Fpack, Funpack y Gzip para ofrecer métodos avanzados de compresión.

Características
Compresión y Descompresión: Facilita la compresión de archivos FITS usando Fpack y la descompresión usando Funpack.
Opciones Avanzadas de Compresión: Incorpora técnicas de compresión HCompress y de lista de píxeles IRAF para una mayor eficiencia.
Compresión sin Pérdida: Diseñado para la compresión sin pérdida. En escenarios donde la única opción es la compresión con pérdida de Fpack (por ejemplo, con archivos de 32 bits), se utiliza GZIP como alternativa.
Interfaz Amigable: Simplifica el manejo de archivos a través de una interfaz intuitiva.
Configuración Personalizable: Incluye opciones para incluir subdirectorios, optar por la eliminación de archivos originales después de la compresión y filtrar archivos por palabras clave.
Timeout Adaptable: Personaliza la duración del timeout para cada operación según las necesidades de procesamiento.

Instalación
Desempaque el contenido del paquete de distribución de OAA Pack en el directorio de su preferencia.
Ejecute el archivo ejecutable para iniciar la aplicación.

Uso
Seleccione la Operación: Elija entre las opciones de compresión y descompresión.
Configure las Configuraciones: Incluya subdirectorios, decida sobre la eliminación de archivos originales y seleccione métodos de compresión según sea necesario.
Elija la Carpeta: Navegue y seleccione la carpeta que contiene los archivos FITS.
Inicie la Operación: Inicie el proceso de compresión o descompresión.

Descargo de Responsabilidad y Licencia
Este software se proporciona "tal cual", sin garantía expresa o implícita. El autor no será responsable de ningún daño o pérdida de datos derivados de su uso.

OAA Pack es de código abierto, distribuido bajo la licencia Attribution-ShareAlike (CC BY-SA). Se permite la redistribución, comercial y no comercial, siempre que se otorgue el crédito apropiado al autor original. Es crucial respetar las licencias de las utilidades Fpack, Funpack y Gzip.

Advertencia sobre Nombres de Carpetas: Debido a las limitaciones de Fpack y Funpack, evite utilizar caracteres especiales como paréntesis (()) en los nombres de carpetas donde se realizarán operaciones de compresión y descompresión. La presencia de estos caracteres en las rutas de las carpetas puede llevar a un comportamiento no deseado o errores durante los procesos de compresión y descompresión. OAA Pack opera dentro de las restricciones de los sistemas operativos y sistemas de archivos subyacentes. Particularmente en Windows, hay un límite máximo tradicional de longitud de ruta de 260 caracteres. Este límite abarca toda la ruta desde la letra del disco a través de todas las carpetas hasta el nombre del archivo. Si la longitud total de la ruta de un archivo excede este límite, OAA-pack podría fallar en procesarlo. Se aconseja a los usuarios mantener sus nombres de archivos y carpetas razonablemente cortos para evitar tales problemas, especialmente al trabajar con directorios anidados.

Contribuciones
¡Las contribuciones son bienvenidas! Si desea mejorar o agregar nuevas funciones, asegúrese de dar crédito al autor original de OAA Pack. Las contribuciones deben respetar las licencias de Fpack, Funpack y Gzip.

Agradecimientos
Gracias a los creadores de Fpack, Funpack y Gzip por su trabajo fundamental. Un agradecimiento especial a ChatGPT en OpenAI por la asistencia invaluable proporcionada en el desarrollo de este software.

Contacto
Para consultas, sugerencias o contribuciones, contacte al autor original en director@observatorialbanya.com