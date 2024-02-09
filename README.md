Overview
OAA Pack is a specialized software tool created by Pere Guerra (Observatori Astronòmic Albanyà) and designed for the compression and decompression of FIT files, offering a user-friendly graphical interface. It harnesses the power of Fpack, Funpack, and Gzip utilities to deliver advanced compression methods.

Features
Compression & Decompression: Facilitates FITS file compression using Fpack and decompression using Funpack
Advanced Compression Options: Incorporates HCompress and IRAF pixel list compression techniques for superior efficiency.
Lossless Compression: Designed for lossless compression. In scenarios where Fpack's lossy compression is the only option (e.g., with 32-bit files), GZIP is employed as an alternative.
User-Friendly Interface: Streamlines file handling through an intuitive interface.
Customizable Settings: Users can include subdirectories, opt for original file deletion post-compression, and filter files by keywords.
Adaptable Timeout: Customize the timeout duration for each operation to suit different processing needs.

Installation
Unpack
Unpack the contents of the OAA Pack distribution package into your preferred directory.
Run the executable file to launch the application.
Usage
Select Operation: Choose between compression and decompression options.
Configure Settings: Include subdirectories, decide on original file deletion, and select compression methods as required.
Choose Folder: Navigate and select the folder containing the FITS files.
Start Operation: Initiate the compression or decompression process.
Disclaimer and License
This software is provided 'as-is', without any express or implied warranty. The author shall not be liable for any damages arising from the use of this software.

OAA Pack is open-source, distributed under the Attribution-ShareAlike (CC BY-SA) license. Redistribution, commercial and non-commercial, is allowed provided appropriate credit is given to the original author. It's crucial to respect the licenses of Fpack, Funpack, and Gzip utilities.

Folder Naming Warning: Due to Fpack and Funpack limitations, please avoid using special characters like parentheses (()) in folder names where compression and decompression operations will be performed. The presence of these characters in folder paths may lead to unintended behavior or errors during the compression and decompression processes. OAA Pack operates within the constraints of the underlying operating systems and file systems. Particularly on Windows, there is a traditional maximum path length limit of 260 characters. This limit encompasses the entire path from the drive letter through all folders to the file name. If the total path length of a file exceeds this limit, OAA-pack might fail to process it. Users are advised to keep their file and folder names reasonably short to avoid such issues, especially when working with nested directories

Contributing
Contributions are welcome! If you wish to improve or add new features, please ensure the original author of OAA Pack is credited. Contributions should respect the licenses of Fpack, Funpack, and Gzip.

Acknowledgements
Thanks to the creators of Fpack, Funpack, and Gzip for their foundational work. A special acknowledgment to ChatGPT at OpenAI for the invaluable assistance provided in developing this software.

Contact
For inquiries, suggestions, or contributions, contact the original author at director@observatorialbanya.com
