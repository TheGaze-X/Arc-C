using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004847 RID: 18503
	[Token(Token = "0x2004847")]
	public abstract class MissionArchiveExteriorPlayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BF31 RID: 114481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF31")]
		[Address(RVA = "0x154FF20", Offset = "0x154EB20", VA = "0x18154FF20", Slot = "4")]
		public virtual void Init(MissionArchiveController controller)
		{
		}

		// Token: 0x0601BF32 RID: 114482
		[Token(Token = "0x601BF32")]
		public abstract void Reset();

		// Token: 0x0601BF33 RID: 114483
		[Token(Token = "0x601BF33")]
		public abstract void Play(bool isHidden);

		// Token: 0x0601BF34 RID: 114484
		[Token(Token = "0x601BF34")]
		public abstract void Stop();

		// Token: 0x0601BF35 RID: 114485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF35")]
		[Address(RVA = "0x154FFE0", Offset = "0x154EBE0", VA = "0x18154FFE0", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0601BF36 RID: 114486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF36")]
		[Address(RVA = "0x154FF80", Offset = "0x154EB80", VA = "0x18154FF80", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0601BF37 RID: 114487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF37")]
		[Address(RVA = "0x1550040", Offset = "0x154EC40", VA = "0x181550040")]
		protected MissionArchiveExteriorPlayer()
		{
		}

		// Token: 0x04024727 RID: 149287
		[Token(Token = "0x4024727")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024728 RID: 149288
		[Token(Token = "0x4024728")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04024729 RID: 149289
		[Token(Token = "0x4024729")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402472A RID: 149290
		[Token(Token = "0x402472A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
