using System;
namespace FMOD
{
	public enum MODE : uint
	{
		DEFAULT,
		LOOP_OFF,
		LOOP_NORMAL,
		LOOP_BIDI = 4u,
		_2D = 8u,
		_3D = 16u,
		HARDWARE = 32u,
		SOFTWARE = 64u,
		CREATESTREAM = 128u,
		CREATESAMPLE = 256u,
		CREATECOMPRESSEDSAMPLE = 512u,
		OPENUSER = 1024u,
		OPENMEMORY = 2048u,
		OPENMEMORY_POINT = 268435456u,
		OPENRAW = 4096u,
		OPENONLY = 8192u,
		ACCURATETIME = 16384u,
		MPEGSEARCH = 32768u,
		NONBLOCKING = 65536u,
		UNIQUE = 131072u,
		_3D_HEADRELATIVE = 262144u,
		_3D_WORLDRELATIVE = 524288u,
		_3D_LOGROLLOFF = 1048576u,
		_3D_LINEARROLLOFF = 2097152u,
		_3D_CUSTOMROLLOFF = 67108864u,
		_3D_IGNOREGEOMETRY = 1073741824u,
		CDDA_FORCEASPI = 4194304u,
		CDDA_JITTERCORRECT = 8388608u,
		UNICODE = 16777216u,
		IGNORETAGS = 33554432u,
		LOWMEM = 134217728u,
		LOADSECONDARYRAM = 536870912u,
		VIRTUAL_PLAYFROMSTART = 2147483648u
	}
}
