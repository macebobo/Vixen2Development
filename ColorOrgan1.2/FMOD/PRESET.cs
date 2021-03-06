using System;
namespace FMOD
{
	internal class PRESET
	{
		public REVERB_PROPERTIES OFF()
		{
			return new REVERB_PROPERTIES(0, 0u, 7.5f, 1f, -10000, -10000, 0, 1f, 1f, 1f, -2602, 0.007f, 0f, 0f, 0f, 200, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 0f, 0f, 63u);
		}
		public REVERB_PROPERTIES GENERIC()
		{
			return new REVERB_PROPERTIES(0, 0u, 7.5f, 1f, -1000, -100, 0, 1.49f, 0.83f, 1f, -2602, 0.007f, 0f, 0f, 0f, 200, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES PADDEDCELL()
		{
			return new REVERB_PROPERTIES(0, 1u, 1.4f, 1f, -1000, -6000, 0, 0.17f, 0.1f, 1f, -1204, 0.001f, 0f, 0f, 0f, 207, 0.002f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES ROOM()
		{
			return new REVERB_PROPERTIES(0, 2u, 1.9f, 1f, -1000, -454, 0, 0.4f, 0.83f, 1f, -1646, 0.002f, 0f, 0f, 0f, 53, 0.003f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES BATHROOM()
		{
			return new REVERB_PROPERTIES(0, 3u, 1.4f, 1f, -1000, -1200, 0, 1.49f, 0.54f, 1f, -370, 0.007f, 0f, 0f, 0f, 1030, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 60f, 63u);
		}
		public REVERB_PROPERTIES LIVINGROOM()
		{
			return new REVERB_PROPERTIES(0, 4u, 2.5f, 1f, -1000, -6000, 0, 0.5f, 0.1f, 1f, -1376, 0.003f, 0f, 0f, 0f, -1104, 0.004f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES STONEROOM()
		{
			return new REVERB_PROPERTIES(0, 5u, 11.6f, 1f, -1000, -300, 0, 2.31f, 0.64f, 1f, -711, 0.012f, 0f, 0f, 0f, 83, 0.017f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES AUDITORIUM()
		{
			return new REVERB_PROPERTIES(0, 6u, 21.6f, 1f, -1000, -476, 0, 4.32f, 0.59f, 1f, -789, 0.02f, 0f, 0f, 0f, -289, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES CONCERTHALL()
		{
			return new REVERB_PROPERTIES(0, 7u, 19.6f, 1f, -1000, -500, 0, 3.92f, 0.7f, 1f, -1230, 0.02f, 0f, 0f, 0f, -2, 0.029f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES CAVE()
		{
			return new REVERB_PROPERTIES(0, 8u, 14.6f, 1f, -1000, 0, 0, 2.91f, 1.3f, 1f, -602, 0.015f, 0f, 0f, 0f, -302, 0.022f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 31u);
		}
		public REVERB_PROPERTIES ARENA()
		{
			return new REVERB_PROPERTIES(0, 9u, 36.2f, 1f, -1000, -698, 0, 7.24f, 0.33f, 1f, -1166, 0.02f, 0f, 0f, 0f, 16, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES HANGAR()
		{
			return new REVERB_PROPERTIES(0, 10u, 50.3f, 1f, -1000, -1000, 0, 10.05f, 0.23f, 1f, -602, 0.02f, 0f, 0f, 0f, 198, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return new REVERB_PROPERTIES(0, 11u, 1.9f, 1f, -1000, -4000, 0, 0.3f, 0.1f, 1f, -1831, 0.002f, 0f, 0f, 0f, -1630, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES HALLWAY()
		{
			return new REVERB_PROPERTIES(0, 12u, 1.8f, 1f, -1000, -300, 0, 1.49f, 0.59f, 1f, -1219, 0.007f, 0f, 0f, 0f, 441, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES STONECORRIDOR()
		{
			return new REVERB_PROPERTIES(0, 13u, 13.5f, 1f, -1000, -237, 0, 2.7f, 0.79f, 1f, -1214, 0.013f, 0f, 0f, 0f, 395, 0.02f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES ALLEY()
		{
			return new REVERB_PROPERTIES(0, 14u, 7.5f, 0.3f, -1000, -270, 0, 1.49f, 0.86f, 1f, -1204, 0.007f, 0f, 0f, 0f, -4, 0.011f, 0f, 0f, 0f, 0.125f, 0.95f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES FOREST()
		{
			return new REVERB_PROPERTIES(0, 15u, 38f, 0.3f, -1000, -3300, 0, 1.49f, 0.54f, 1f, -2560, 0.162f, 0f, 0f, 0f, -229, 0.088f, 0f, 0f, 0f, 0.125f, 1f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 79f, 100f, 63u);
		}
		public REVERB_PROPERTIES CITY()
		{
			return new REVERB_PROPERTIES(0, 16u, 7.5f, 0.5f, -1000, -800, 0, 1.49f, 0.67f, 1f, -2273, 0.007f, 0f, 0f, 0f, -1691, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 50f, 100f, 63u);
		}
		public REVERB_PROPERTIES MOUNTAINS()
		{
			return new REVERB_PROPERTIES(0, 17u, 100f, 0.27f, -1000, -2500, 0, 1.49f, 0.21f, 1f, -2780, 0.3f, 0f, 0f, 0f, -1434, 0.1f, 0f, 0f, 0f, 0.25f, 1f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 27f, 100f, 31u);
		}
		public REVERB_PROPERTIES QUARRY()
		{
			return new REVERB_PROPERTIES(0, 18u, 17.5f, 1f, -1000, -1000, 0, 1.49f, 0.83f, 1f, -10000, 0.061f, 0f, 0f, 0f, 500, 0.025f, 0f, 0f, 0f, 0.125f, 0.7f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES PLAIN()
		{
			return new REVERB_PROPERTIES(0, 19u, 42.5f, 0.21f, -1000, -2000, 0, 1.49f, 0.5f, 1f, -2466, 0.179f, 0f, 0f, 0f, -1926, 0.1f, 0f, 0f, 0f, 0.25f, 1f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 21f, 100f, 63u);
		}
		public REVERB_PROPERTIES PARKINGLOT()
		{
			return new REVERB_PROPERTIES(0, 20u, 8.3f, 1f, -1000, 0, 0, 1.65f, 1.5f, 1f, -1363, 0.008f, 0f, 0f, 0f, -1153, 0.012f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 100f, 100f, 31u);
		}
		public REVERB_PROPERTIES SEWERPIPE()
		{
			return new REVERB_PROPERTIES(0, 21u, 1.7f, 0.8f, -1000, -1000, 0, 2.81f, 0.14f, 1f, 429, 0.014f, 0f, 0f, 0f, 1023, 0.021f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 0f, -5f, 5000f, 250f, 0f, 80f, 60f, 63u);
		}
		public REVERB_PROPERTIES UNDERWATER()
		{
			return new REVERB_PROPERTIES(0, 22u, 1.8f, 1f, -1000, -4000, 0, 1.49f, 0.1f, 1f, -449, 0.007f, 0f, 0f, 0f, 1700, 0.011f, 0f, 0f, 0f, 0.25f, 0f, 1.18f, 0.348f, -5f, 5000f, 250f, 0f, 100f, 100f, 63u);
		}
		public REVERB_PROPERTIES DRUGGED()
		{
			return new REVERB_PROPERTIES(0, 23u, 1.9f, 0.5f, -1000, 0, 0, 8.39f, 1.39f, 1f, -115, 0.002f, 0f, 0f, 0f, 985, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 0.25f, 1f, -5f, 5000f, 250f, 0f, 100f, 100f, 31u);
		}
		public REVERB_PROPERTIES DIZZY()
		{
			return new REVERB_PROPERTIES(0, 24u, 1.8f, 0.6f, -1000, -400, 0, 17.23f, 0.56f, 1f, -1713, 0.02f, 0f, 0f, 0f, -613, 0.03f, 0f, 0f, 0f, 0.25f, 1f, 0.81f, 0.31f, -5f, 5000f, 250f, 0f, 100f, 100f, 31u);
		}
		public REVERB_PROPERTIES PSYCHOTIC()
		{
			return new REVERB_PROPERTIES(0, 25u, 1f, 0.5f, -1000, -151, 0, 7.56f, 0.91f, 1f, -626, 0.02f, 0f, 0f, 0f, 774, 0.03f, 0f, 0f, 0f, 0.25f, 0f, 4f, 1f, -5f, 5000f, 250f, 0f, 100f, 100f, 31u);
		}
		public REVERB_PROPERTIES PS2_ROOM()
		{
			return new REVERB_PROPERTIES(0, 1u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_STUDIO_A()
		{
			return new REVERB_PROPERTIES(0, 2u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_STUDIO_B()
		{
			return new REVERB_PROPERTIES(0, 3u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_STUDIO_C()
		{
			return new REVERB_PROPERTIES(0, 4u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_HALL()
		{
			return new REVERB_PROPERTIES(0, 5u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_SPACE()
		{
			return new REVERB_PROPERTIES(0, 6u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_ECHO()
		{
			return new REVERB_PROPERTIES(0, 7u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_DELAY()
		{
			return new REVERB_PROPERTIES(0, 8u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
		public REVERB_PROPERTIES PS2_PIPE()
		{
			return new REVERB_PROPERTIES(0, 9u, 0f, 0f, 0, 0, 0, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 799u);
		}
	}
}
