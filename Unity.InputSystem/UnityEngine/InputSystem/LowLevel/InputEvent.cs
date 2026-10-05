using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;
using UnityEngineInternal.Input;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[StructLayout(2)]
	public struct InputEvent
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000083D0 File Offset: 0x000065D0
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public FourCC type
		{
			[Token(Token = "0x6000FDC")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return default(FourCC);
			}
			[Token(Token = "0x6000FDD")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000083E8 File Offset: 0x000065E8
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047B")]
		public uint sizeInBytes
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x4007530", Offset = "0x4006130", VA = "0x184007530")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x56DE960", Offset = "0x56DD560", VA = "0x1856DE960")]
			set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00008400 File Offset: 0x00006600
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047C")]
		public int eventId
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x56DE8B0", Offset = "0x56DD4B0", VA = "0x1856DE8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x56DE930", Offset = "0x56DD530", VA = "0x1856DE930")]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00008418 File Offset: 0x00006618
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047D")]
		public int deviceId
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x56DE8A0", Offset = "0x56DD4A0", VA = "0x1856DE8A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FE3")]
			[Address(RVA = "0x56DE920", Offset = "0x56DD520", VA = "0x1856DE920")]
			set
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00008430 File Offset: 0x00006630
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047E")]
		public double time
		{
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0x56DE8D0", Offset = "0x56DD4D0", VA = "0x1856DE8D0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x56DEA10", Offset = "0x56DD610", VA = "0x1856DEA10")]
			set
			{
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00008448 File Offset: 0x00006648
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047F")]
		internal double internalTime
		{
			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0x4007440", Offset = "0x4006040", VA = "0x184007440")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x55F8490", Offset = "0x55F7090", VA = "0x1855F8490")]
			set
			{
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x56DE7E0", Offset = "0x56DD3E0", VA = "0x1856DE7E0")]
		public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1.0)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00008460 File Offset: 0x00006660
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000480")]
		public bool handled
		{
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x56DE8C0", Offset = "0x56DD4C0", VA = "0x1856DE8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x56DE940", Offset = "0x56DD540", VA = "0x1856DE940")]
			set
			{
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x56DE520", Offset = "0x56DD120", VA = "0x1856DE520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x56DE500", Offset = "0x56DD100", VA = "0x1856DE500")]
		internal unsafe static InputEvent* GetNextInMemory(InputEvent* currentPtr)
		{
			return null;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x56DE390", Offset = "0x56DCF90", VA = "0x1856DE390")]
		internal unsafe static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer)
		{
			return null;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x56DE350", Offset = "0x56DCF50", VA = "0x1856DE350")]
		public unsafe static bool Equals(InputEvent* first, InputEvent* second)
		{
			return default(bool);
		}

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		private const uint kHandledMask = 2147483648U;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		private const uint kIdMask = 2147483647U;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		internal const int kBaseEventSize = 20;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		public const int InvalidEventId = 0;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		internal const int kAlignment = 4;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private NativeInputEvent m_Event;
	}
}
