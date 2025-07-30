---
description: >-
  This guide helps you to prevent lagging (TPS ISSUES) on your servers by
  optimizing the configurations
---

# 🛠️ Server Optimization Guide

Note for users that are on vanilla, Fabric or Spigot (or anything below Paper) - go to your server.properties and change `sync-chunk-writes` to `false`. This option is forcibly set to false on Paper and its forks, but on other server implementations you need to switch this to false manually. This allows the server to save chunks off the main thread, lessening the load on the main tick loop.

Guide for version 1.21.5. Some things may still apply to 1.15 - 1.21.4.

Based on [this guide](https://www.spigotmc.org/threads/guide-server-optimization%E2%9A%A1.283181/) and other sources (all of them are linked throughout the guide when relevant).

Use the table of contents located above (next to `README.md`) to easily navigate throughout this guide.

## INTRO

There will never be a guide that will give you perfect results. Each server has their own needs and limits on how much you can or are willing to sacrifice. Tinkering around with the options to fine tune them to your servers needs is what it's all about. This guide only aims to help you understand what options have impact on performance and what exactly they change. If you think you found inaccurate information within this guide, you're free to open an issue or set up a pull request to correct it.

## PREPARATIONS

### Server JAR

Your choice of server software can make a huge difference in performance and API possibilities. There are currently multiple viable popular server JARs, but there are also a few that you should stay away from for various reasons.

Recommended top picks:

* [Paper](https://github.com/PaperMC/Paper) - The most popular server software that aims to improve performance while fixing gameplay and mechanics inconsistencies.
* [Purpur](https://github.com/PurpurMC/Purpur) - Paper fork focused on features and the freedom of customization.

You should stay away from:

* Any paid server JAR that claims async anything - 99.99% chance of being a scam.
* Bukkit/CraftBukkit/Spigot - Extremely outdated in terms of performance compared to other server software you have access to.
* Any plugin/software that enables/disables/reloads plugins on runtime. See [this section](https://github.com/YouHaveTrouble/minecraft-optimization#plugins-enablingdisabling-other-plugins) to understand why.
* Many forks further downstream from Paper or Purpur will encounter instability and other issues. If you're seeking more performance gains, optimize your server or invest in a personal private fork.



<details>

<summary>#3 Helpers</summary>

`Good starting value: true`

Enable this to hide ores from x-rayers. For detailed configuration of this feature check out [Configuring Anti-Xray](https://docs.papermc.io/paper/anti-xray). Enabling this will actually decrease performance, however it is much more efficient than any anti-xray plugin. In most cases the performance impact will be negligible.

**nether-ceiling-void-damage-height**



`Good starting value: 127`

If this option is greater that `0`, players above the set y level will be damaged as if they were in the void. This will prevent players from using the nether roof. Vanilla nether is 128 blocks tall, so you should probably set it to `127`. If you modify the height of the nether in any way you should set this to `[your_nether_height] - 1`.

\
\


</details>

<details>

<summary>#4 Java Startup flags</summary>

## Java startup flags



[Vanilla Minecraft and Minecraft server software in version 1.20.5+ requires Java 21 or higher](https://docs.papermc.io/java-install-update). Oracle has changed their licensing, and there is no longer a compelling reason to get your java from them. Recommended vendors are [Adoptium](https://adoptium.net/) and [Amazon Corretto](https://aws.amazon.com/corretto/). Alternative JVM implementations such as OpenJ9 or GraalVM can work, however they are not supported by Paper and have been known to cause issues, therefore they are not currently recommended.

Your garbage collector can be configured to reduce lag spikes caused by big garbage collector tasks. You can find startup flags optimized for Minecraft servers [here](https://docs.papermc.io/paper/aikars-flags) [`SOG`](https://www.spigotmc.org/threads/guide-server-optimization%E2%9A%A1.283181/). Keep in mind that this recommendation will not work on alternative JVM implementations. It's recommended to use the [flags.sh](https://flags.sh/) startup flags generator to get the correct startup flags for your server

In addition, adding the beta flag `--add-modules=jdk.incubator.vector` before `-jar` in your startup flags can improve performance. This flag enables Pufferfish to use SIMD instructions on your CPU, making some maths faster. Currently, it's only used for making rendering in game plugin maps (like imageonmaps) possibly 8 times faster.

</details>
