# HELPERS

#### [paper-world configuration](https://docs.papermc.io/paper/reference/world-configuration)



**anti-xray.enabled**



`Good starting value: true`

Enable this to hide ores from x-rayers. For detailed configuration of this feature check out [Configuring Anti-Xray](https://docs.papermc.io/paper/anti-xray). Enabling this will actually decrease performance, however it is much more efficient than any anti-xray plugin. In most cases the performance impact will be negligible.

**nether-ceiling-void-damage-height**



`Good starting value: 127`

If this option is greater that `0`, players above the set y level will be damaged as if they were in the void. This will prevent players from using the nether roof. Vanilla nether is 128 blocks tall, so you should probably set it to `127`. If you modify the height of the nether in any way you should set this to `[your_nether_height] - 1`.

\
