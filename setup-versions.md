---
icon: code-pull-request
cover: .gitbook/assets/Untitled design (10).png
coverY: 0
---

# SETUP VERSIONS

### Minecraft Server Versions (Software Types)

This section explains the various server software options available for your Minecraft server. Each type offers different features, performance characteristics, and compatibility with mods or plugins. Choosing the right server software is crucial for your server's functionality and performance.

<figure><img src=".gitbook/assets/image (29).png" alt=""><figcaption></figcaption></figure>

***

#### Understanding Server Software Types

Minecraft servers can run on different "server JARs" or "server software distributions." These are essentially modified or optimized versions of the base Minecraft server, designed to cater to various needs, from pure vanilla gameplay to heavily modded or plugin-driven experiences.

The interface categorizes these options into "Recommended," "Established," and "Experimental," indicating their stability and maturity.

***

#### Recommended Server Types

These are generally the most popular, stable, and widely used server software options, suitable for a broad range of server owners.

* Vanilla
  * What it is: The official Minecraft server software released by Mojang.
  * What it's used for: Running a pure, unmodded Minecraft experience. Ideal for small, private servers or those wanting the game exactly as Mojang intended, without any third-party additions. It does not support plugins or extensive mods.
* Paper
  * What it is: A highly optimized version of Spigot (which itself is a modified Vanilla server), focusing on performance and efficiency.
  * What it's used for: Running a performant Minecraft server that supports a vast ecosystem of "plugins." This is the most common choice for public servers, as it significantly reduces lag and allows for custom features (like land claims, economy, minigames) through plugins.
* Fabric
  * What it is: A lightweight, modular modding toolchain.
  * What it's used for: Running servers with "mods" that are built specifically for the Fabric ecosystem. Often used for client-side and server-side performance mods, or specific content mods. Not compatible with Paper/Spigot plugins.
* Forge
  * What it is: The most well-known and long-standing modding API for Minecraft.
  * What it's used for: Running heavily "modded" Minecraft servers that fundamentally change gameplay. Requires players to install Forge on their game client. Widely used for large modpacks with new blocks, items, and dimensions. Not compatible with Paper/Spigot plugins.
* NeoForge
  * What it is: A direct continuation and evolution of the Forge project.
  * What it's used for: Similar to Forge, used for running servers with "mods." It aims to provide continued development and community focus for Forge-style modding. Compatible with mods built for NeoForge. Not compatible with Paper/Spigot plugins.

***

#### Established Server Types

These are well-known and mature alternatives or specialized forks, often building upon the "Recommended" options to offer specific advantages.

* Purpur
  * What it is: An advanced fork of Paper, offering even more customization options and performance improvements.
  * What it's used for: Servers that demand extreme control over performance and gameplay mechanics. It supports Paper/Spigot plugins and is suitable for very large player counts needing peak optimization.
* Pufferfish
  * What it is: Another highly optimized Paper fork, often including aggressive performance gains and sometimes built-in anti-cheat measures.
  * What it's used for: Large servers that need top-tier performance and potentially integrated protection against cheats. It supports Paper/Spigot plugins.
* Sponge
  * What it is: A modding API designed to support its own "plugins" while being compatible with Forge mods.
  * What it's used for: Servers that want to combine the extensive content of Forge mods with server-side administrative or gameplay "plugins" (Sponge's own plugin system). Not compatible with Bukkit/Spigot/Paper plugins.
* Spigot
  * What it is: An optimized version of the Vanilla server that introduced the Bukkit API, enabling the use of "plugins."
  * What it's used for: A foundational choice for servers wanting to add features via "plugins." While Paper has largely superseded it for pure performance, Spigot remains a solid and widely supported option for plugin-based servers.

***

#### Experimental Server Types

These are newer, less mature, or highly specialized server types. They may offer cutting-edge features or extreme optimizations but come with a higher risk of instability or limited community support. They are often indicated with a warning (⚠️) sign.

* Folia
  * What it is: An ambitious, experimental fork of Paper that aims for true multi-threading, allowing different parts of the server (chunks/dimensions) to run on separate CPU cores simultaneously.
  * What it's used for: Servers requiring revolutionary performance for extremely high player counts and intense activity, by fully utilizing modern multi-core CPUs. Note: Requires plugins to be updated for Folia compatibility.
* Quilt
  * What it is: A community-driven, modern, and open-source mod loader and API, broadly compatible with Fabric mods.
  * What it's used for: Similar to Fabric, used for running modded gameplay with a focus on modern development practices and community involvement. Supports mods built for Quilt/Fabric.
* Canvas
  * What it is: A relatively new and experimental server type, often focused on unique optimizations or specialized use cases.
  * What it's used for: For developers or adventurous server owners exploring cutting-edge and potentially niche server technologies. Likely to be unstable or have limited documentation.
* DivineMC
  * What it is: Likely a specialized or optimized server software, potentially a fork of another type (like Paper/Spigot), tailored for specific community needs (e.g., specific game modes, enhanced anti-cheat, or performance for particular setups).
  * What it's used for: Server owners with very specific requirements that align with the unique features or optimizations offered by this particular distribution.

***

In essence, your choice of server software dictates:

* Performance: How well your server handles players and activity.
* Mod/Plugin Compatibility: What kind of custom features you can add.
* Stability: How reliably your server will run.
* Community Support: How easily you can find help and resources.
