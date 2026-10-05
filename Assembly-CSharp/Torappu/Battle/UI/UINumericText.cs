using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200338E RID: 13198
	[Token(Token = "0x200338E")]
	[RequireComponent(typeof(Text))]
	public abstract class UINumericText : UIPopup
	{
		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x060150AF RID: 86191
		[Token(Token = "0x170031FD")]
		protected abstract string format { [Token(Token = "0x60150AF")] get; }

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x060150B0 RID: 86192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031FE")]
		protected Text label
		{
			[Token(Token = "0x60150B0")]
			[Address(RVA = "0xD7A0E0", Offset = "0xD78CE0", VA = "0x180D7A0E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060150B1 RID: 86193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B1")]
		[Address(RVA = "0xD79D70", Offset = "0xD78970", VA = "0x180D79D70", Slot = "11")]
		public virtual void Init(ref Modifier modifier, Transform spawnPoint)
		{
		}

		// Token: 0x060150B2 RID: 86194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B2")]
		[Address(RVA = "0xD79BF0", Offset = "0xD787F0", VA = "0x180D79BF0", Slot = "12")]
		public virtual void Init(ref Modifier modifier, int overrideValue, Transform spawnPoint)
		{
		}

		// Token: 0x060150B3 RID: 86195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B3")]
		[Address(RVA = "0xD79F80", Offset = "0xD78B80", VA = "0x180D79F80", Slot = "13")]
		protected virtual void SetColor(ref Modifier modifier)
		{
		}

		// Token: 0x060150B4 RID: 86196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B4")]
		[Address(RVA = "0xD79B70", Offset = "0xD78770", VA = "0x180D79B70")]
		private void Awake()
		{
		}

		// Token: 0x060150B5 RID: 86197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150B5")]
		[Address(RVA = "0xD7A040", Offset = "0xD78C40", VA = "0x180D7A040")]
		protected UINumericText()
		{
		}

		// Token: 0x040190C2 RID: 102594
		[Token(Token = "0x40190C2")]
		[FieldOffset(Offset = "0x30")]
		private Text m_label;

		// Token: 0x040190C3 RID: 102595
		[Token(Token = "0x40190C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_label;

		// Token: 0x040190C4 RID: 102596
		[Token(Token = "0x40190C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040190C5 RID: 102597
		[Token(Token = "0x40190C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x040190C6 RID: 102598
		[Token(Token = "0x40190C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x040190C7 RID: 102599
		[Token(Token = "0x40190C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040190C8 RID: 102600
		[Token(Token = "0x40190C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
