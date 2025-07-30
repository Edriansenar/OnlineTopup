# STARTUP FLAGS



[Vanilla Minecraft and Minecraft server software in version 1.20.5+ requires Java 21 or higher](https://docs.papermc.io/java-install-update). Oracle has changed their licensing, and there is no longer a compelling reason to get your java from them. Recommended vendors are [Adoptium](https://adoptium.net/) and [Amazon Corretto](https://aws.amazon.com/corretto/). Alternative JVM implementations such as OpenJ9 or GraalVM can work, however they are not supported by Paper and have been known to cause issues, therefore they are not currently recommended.

Your garbage collector can be configured to reduce lag spikes caused by big garbage collector tasks. You can find startup flags optimized for Minecraft servers [here](https://docs.papermc.io/paper/aikars-flags) [`SOG`](https://www.spigotmc.org/threads/guide-server-optimization%E2%9A%A1.283181/). Keep in mind that this recommendation will not work on alternative JVM implementations. It's recommended to use the [flags.sh](https://flags.sh/) startup flags generator to get the correct startup flags for your server
