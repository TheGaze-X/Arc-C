using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200615D RID: 24925
	[Token(Token = "0x200615D")]
	public class BossRushBattleFinishRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023FA7 RID: 147367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FA7")]
		[Address(RVA = "0x1E9EF40", Offset = "0x1E9DB40", VA = "0x181E9EF40")]
		public void Render(string itemId, bool isMax, int itemCount, int firstPassCount, bool forcedShowNormal = false)
		{
		}

		// Token: 0x06023FA8 RID: 147368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FA8")]
		[Address(RVA = "0x1E9F320", Offset = "0x1E9DF20", VA = "0x181E9F320")]
		private string _GetFormatCount(int rewardCount)
		{
			return null;
		}

		// Token: 0x06023FA9 RID: 147369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FA9")]
		[Address(RVA = "0x1E9F3D0", Offset = "0x1E9DFD0", VA = "0x181E9F3D0")]
		public BossRushBattleFinishRewardItemView()
		{
		}

		// Token: 0x04031F87 RID: 204679
		[Token(Token = "0x4031F87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04031F88 RID: 204680
		[Token(Token = "0x4031F88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031F89 RID: 204681
		[Token(Token = "0x4031F89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x04031F8A RID: 204682
		[Token(Token = "0x4031F8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMax;

		// Token: 0x04031F8B RID: 204683
		[Token(Token = "0x4031F8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _firstPassTagGo;

		// Token: 0x04031F8C RID: 204684
		[Token(Token = "0x4031F8C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textFirstPassCount;

		// Token: 0x04031F8D RID: 204685
		[Token(Token = "0x4031F8D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04031F8E RID: 204686
		[Token(Token = "0x4031F8E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _normalWidth;

		// Token: 0x04031F8F RID: 204687
		[Token(Token = "0x4031F8F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _firstPassWidth;

		// Token: 0x04031F90 RID: 204688
		[Token(Token = "0x4031F90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031F91 RID: 204689
		[Token(Token = "0x4031F91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetFormatCount;

		// Token: 0x04031F92 RID: 204690
		[Token(Token = "0x4031F92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
