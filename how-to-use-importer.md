---
icon: folder-arrow-down
cover: .gitbook/assets/Untitled design (10).png
coverY: 0
---

# HOW TO USE IMPORTER

## SFTP Connection Setup

This guide explains how to configure and establish a secure file transfer (SFTP) connection to your remote server using the provided interface. SFTP is a network protocol that provides file access, file transfer, and file management functionalities over any reliable data stream. It's crucial for securely managing files on your game server, website, or any other remote host.

***

## UNDERSTANDING THE INTERFACE

The interface is divided into two main sections: Saved Profiles and Connection Details.

**Saved Profiles**

This section allows you to manage pre-configured connection settings for different servers or purposes.

* Select a profile:
  * Dropdown Menu: Use this to choose from a list of previously saved connection profiles. This is convenient if you frequently connect to the same server or different servers.
  * "Save" Button: After entering your connection details, click this button to save the current configuration as a new profile or update an existing one. This will prevent you from having to re-enter credentials every time you want to connect.

**Connection Details**

This is where you input the necessary information to connect to your remote server.

* HOST:
  * Input Field: Enter the hostname or IP address of your remote server. This is the unique identifier for the server you want to connect to.
  * Description: "The host address of the remote server."
* PORT:
  * Input Field: Enter the port number for the SFTP service on your remote server. The default SFTP port is `22`, but it can sometimes be changed for security reasons. The screenshot shows `2022`, which is an example of a non-standard port.
  * Description: "The port number of the remote server."
* USERNAME:
  * Input Field: Enter the username required to authenticate with the remote server. This is typically provided by your hosting provider or set up when you configure user accounts on your server.
  * Description: "The username to authenticate with."
* PASSWORD:
  * Input Field: Enter the password associated with the provided username for authentication.
  * Description: "The password to authenticate with."
* SOURCE PATH:
  * Input Field: This specifies the starting directory on your _local machine_ (or where you want to import files from). The default `/` usually refers to the root directory from which you will select files to upload.
  * Description: "The path to import files from."
  * Note: If this is an _upload_ interface, "Source Path" would be where files are located _locally_ before being sent to the remote server. If it's a _download_ or _sync_ interface, it might refer to the remote starting point. Given the "Destination Path" below, it's highly likely this refers to the _remote_ source if you are _pulling_ files, or the _local_ source if you are _pushing_ files. Without more context, assuming this is an "upload" or "transfer from local to remote" context, the "Source Path" would be on your local system. However, considering the general nature of SFTP clients within a panel, it often implies transferring files _from_ the remote server _to_ the panel's file manager, or _from_ your local machine _to_ the remote server via the panel. Let's assume it's the _remote_ source path for pulling/downloading, or if you're importing INTO the panel's file manager, it's the path ON THE REMOTE SERVER you are connecting to.
* DESTINATION PATH:
  * Input Field: This specifies the target directory on the _remote server_ where files will be transferred to. The default `/` typically refers to the root directory of the connected user.
  * Description: "The path where files will be imported to."
  * Note: For a typical SFTP upload, this is the folder on the _remote server_ where you want your files to end up.
* SFTP Protocol Selection:
  * Dropdown Menu: This confirms that the connection method is SFTP (SSH File Transfer Protocol). While sometimes other protocols like FTP or FTPS might be offered, SFTP is generally preferred for its enhanced security as it encrypts both data and commands.
* "Connect" Button:
  * Click this button after filling in all the connection details to attempt to establish an SFTP connection to the remote server.

## HOW TO USE

* Enter Connection Details: Fill in the HOST, PORT, USERNAME, and PASSWORD fields with the credentials provided by your server host or your server's configuration.
* Specify Paths:
  * For uploading files to your server: The SOURCE PATH would be relevant if you're importing from another remote location. However, if you're uploading from your _local computer_, this field might be automatically handled by the subsequent file selection process once connected, or it might be the starting point on the _remote_ server for Browse. The DESTINATION PATH is crucial – this is where you want your files to be placed on your server (e.g., `/home/minecraft/server/plugins`).
  * For downloading files from your server: The SOURCE PATH would be the directory on your remote server you wish to download from (e.g., `/home/minecraft/server/world`), and the DESTINATION PATH might refer to a location within the panel's file manager or a temporary download folder.
  * Important: Pay close attention to these paths to ensure files are transferred to and from the correct locations. The default `/` means the root directory of the connected user.
* Save Profile (Optional but Recommended): Once you've successfully connected, or even before, click the "Save" button in the "Saved Profiles" section to store these connection details for future use. Give it a descriptive name like "My Minecraft Server SFTP" or "Website FTP".
* Connect: Click the "Connect" button.
* Manage Files: If the connection is successful, you will typically be presented with a file browser interface, allowing you to upload, download, delete, rename, and manage files on your remote server securely.

<figure><img src=".gitbook/assets/image (28).png" alt=""><figcaption></figcaption></figure>

#### Troubleshooting Common Issues

* "Connection refused" or "Connection timed out":
  * Double-check the HOST and PORT.
  * Ensure your server is running and accessible from the internet.
  * Check for firewall issues on your server or your local network that might be blocking the connection.
* "Authentication failed":
  * Verify your USERNAME and PASSWORD carefully. Passwords are case-sensitive.
  * Ensure the user has SFTP access enabled on the server.
* Incorrect Paths: If you connect but can't find your files, or files don't appear where expected, double-check your SOURCE PATH and DESTINATION PATH.
