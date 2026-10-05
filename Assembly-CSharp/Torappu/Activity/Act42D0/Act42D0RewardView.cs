using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073AE RID: 29614
	[Token(Token = "0x20073AE")]
	public class Act42D0RewardView : DataBinder<Act42D0RewardProperty>
	{
		// Token: 0x06029DA7 RID: 171431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA7")]
		[Address(RVA = "0x25765E0", Offset = "0x25751E0", VA = "0x1825765E0", Slot = "7")]
		public override void OnValueChanged(Act42D0RewardProperty property)
		{
		}

		// Token: 0x06029DA8 RID: 171432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA8")]
		[Address(RVA = "0x25768E0", Offset = "0x25754E0", VA = "0x1825768E0")]
		private void _LoadIcon(string itemId, string iconId)
		{
		}

		// Token: 0x06029DA9 RID: 171433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA9")]
		[Address(RVA = "0x2576A20", Offset = "0x2575620", VA = "0x182576A20")]
		private void _UnloadIconIfNot()
		{
		}

		// Token: 0x06029DAA RID: 171434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DAA")]
		[Address(RVA = "0x2576580", Offset = "0x2575180", VA = "0x182576580")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029DAB RID: 171435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DAB")]
		[Address(RVA = "0x2576BC0", Offset = "0x25757C0", VA = "0x182576BC0")]
		public Act42D0RewardView()
		{
		}

		// Token: 0x0403BFA7 RID: 245671
		[Token(Token = "0x403BFA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42D0RewardAreaView _areaView;

		// Token: 0x0403BFA8 RID: 245672
		[Token(Token = "0x403BFA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act42D0RewardTitleView _titleView;

		// Token: 0x0403BFA9 RID: 245673
		[Token(Token = "0x403BFA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act42D0RewardStageView _stageView;

		// Token: 0x0403BFAA RID: 245674
		[Token(Token = "0x403BFAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _hint;

		// Token: 0x0403BFAB RID: 245675
		[Token(Token = "0x403BFAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403BFAC RID: 245676
		[Token(Token = "0x403BFAC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403BFAD RID: 245677
		[Token(Token = "0x403BFAD")]
		[FieldOffset(Offset = "0x50")]
		private Sprite m_cachedSprite;

		// Token: 0x0403BFAE RID: 245678
		[Token(Token = "0x403BFAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BFAF RID: 245679
		[Token(Token = "0x403BFAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x0403BFB0 RID: 245680
		[Token(Token = "0x403BFB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnloadIconIfNot;

		// Token: 0x0403BFB1 RID: 245681
		[Token(Token = "0x403BFB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403BFB2 RID: 245682
		[Token(Token = "0x403BFB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
