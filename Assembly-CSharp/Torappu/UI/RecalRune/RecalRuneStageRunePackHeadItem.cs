using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B3 RID: 18355
	[Token(Token = "0x20047B3")]
	public class RecalRuneStageRunePackHeadItem : RecalRuneStageRunePackItemBase
	{
		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0601BCA5 RID: 113829 RVA: 0x000A63F8 File Offset: 0x000A45F8
		[Token(Token = "0x17004214")]
		public override float preferredWidth
		{
			[Token(Token = "0x601BCA5")]
			[Address(RVA = "0x1531180", Offset = "0x152FD80", VA = "0x181531180", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x0601BCA6 RID: 113830 RVA: 0x000A6410 File Offset: 0x000A4610
		[Token(Token = "0x17004215")]
		public override float preferredHeight
		{
			[Token(Token = "0x601BCA6")]
			[Address(RVA = "0x1531120", Offset = "0x152FD20", VA = "0x181531120", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601BCA7 RID: 113831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA7")]
		[Address(RVA = "0x1530F50", Offset = "0x152FB50", VA = "0x181530F50", Slot = "15")]
		public override void Render(IRecalRunePack pack)
		{
		}

		// Token: 0x0601BCA8 RID: 113832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA8")]
		[Address(RVA = "0x1531080", Offset = "0x152FC80", VA = "0x181531080")]
		public RecalRuneStageRunePackHeadItem()
		{
		}

		// Token: 0x04024252 RID: 148050
		[Token(Token = "0x4024252")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _essentialVariant;

		// Token: 0x04024253 RID: 148051
		[Token(Token = "0x4024253")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _rewardingVariant;

		// Token: 0x04024254 RID: 148052
		[Token(Token = "0x4024254")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _essentialTitleText;

		// Token: 0x04024255 RID: 148053
		[Token(Token = "0x4024255")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x04024256 RID: 148054
		[Token(Token = "0x4024256")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x04024257 RID: 148055
		[Token(Token = "0x4024257")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x04024258 RID: 148056
		[Token(Token = "0x4024258")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024259 RID: 148057
		[Token(Token = "0x4024259")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
