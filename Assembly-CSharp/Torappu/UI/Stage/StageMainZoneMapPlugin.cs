using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006916 RID: 26902
	[Token(Token = "0x2006916")]
	public abstract class StageMainZoneMapPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060268A7 RID: 157863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268A7")]
		[Address(RVA = "0x219AC00", Offset = "0x2199800", VA = "0x18219AC00", Slot = "4")]
		public virtual void OnMapInitiated(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x060268A8 RID: 157864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268A8")]
		[Address(RVA = "0x219AC70", Offset = "0x2199870", VA = "0x18219AC70", Slot = "5")]
		public virtual void OnMapPositionChanged(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x060268A9 RID: 157865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268A9")]
		[Address(RVA = "0x219ACE0", Offset = "0x21998E0", VA = "0x18219ACE0")]
		protected StageMainZoneMapPlugin()
		{
		}

		// Token: 0x04036597 RID: 222615
		[Token(Token = "0x4036597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapInitiated;

		// Token: 0x04036598 RID: 222616
		[Token(Token = "0x4036598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMapPositionChanged;

		// Token: 0x04036599 RID: 222617
		[Token(Token = "0x4036599")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006917 RID: 26903
		[Token(Token = "0x2006917")]
		public struct MapPosInfo : IHotfixable
		{
			// Token: 0x0403659A RID: 222618
			[Token(Token = "0x403659A")]
			[FieldOffset(Offset = "0x0")]
			public float positionValue;

			// Token: 0x0403659B RID: 222619
			[Token(Token = "0x403659B")]
			[FieldOffset(Offset = "0x4")]
			public float mapLength;

			// Token: 0x0403659C RID: 222620
			[Token(Token = "0x403659C")]
			[FieldOffset(Offset = "0x8")]
			public float currBaseLine;

			// Token: 0x0403659D RID: 222621
			[Token(Token = "0x403659D")]
			[FieldOffset(Offset = "0xC")]
			public float backgroundMoveSpeed;

			// Token: 0x0403659E RID: 222622
			[Token(Token = "0x403659E")]
			[FieldOffset(Offset = "0x0")]
			public static StageMainZoneMapPlugin.MapPosInfo EMPTY;
		}
	}
}
