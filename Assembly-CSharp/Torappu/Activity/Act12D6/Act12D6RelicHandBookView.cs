using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AFB RID: 31483
	[Token(Token = "0x2007AFB")]
	public class Act12D6RelicHandBookView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C156 RID: 180566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C156")]
		[Address(RVA = "0x27F5DD0", Offset = "0x27F49D0", VA = "0x1827F5DD0")]
		public void Render(Act12D6RelicHandBookStateBean stateBean, string chosen)
		{
		}

		// Token: 0x0602C157 RID: 180567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C157")]
		[Address(RVA = "0x27F6640", Offset = "0x27F5240", VA = "0x1827F6640")]
		private void _RenderEmptyDetailPart()
		{
		}

		// Token: 0x0602C158 RID: 180568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C158")]
		[Address(RVA = "0x27F6190", Offset = "0x27F4D90", VA = "0x1827F6190")]
		private void _RenderDetailPart(string relicId)
		{
		}

		// Token: 0x0602C159 RID: 180569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C159")]
		[Address(RVA = "0x27F6060", Offset = "0x27F4C60", VA = "0x1827F6060")]
		private string _GenerateRelicProgress(PlayerRelicHandBookData relic)
		{
			return null;
		}

		// Token: 0x0602C15A RID: 180570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15A")]
		[Address(RVA = "0x27F6830", Offset = "0x27F5430", VA = "0x1827F6830")]
		public Act12D6RelicHandBookView()
		{
		}

		// Token: 0x0403FE2F RID: 261679
		[Token(Token = "0x403FE2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12D6RelicHandBookGridAdapter _relicHandBookAdapter;

		// Token: 0x0403FE30 RID: 261680
		[Token(Token = "0x403FE30")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403FE31 RID: 261681
		[Token(Token = "0x403FE31")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FE32 RID: 261682
		[Token(Token = "0x403FE32")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEffect;

		// Token: 0x0403FE33 RID: 261683
		[Token(Token = "0x403FE33")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403FE34 RID: 261684
		[Token(Token = "0x403FE34")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCondition;

		// Token: 0x0403FE35 RID: 261685
		[Token(Token = "0x403FE35")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _imgLock;

		// Token: 0x0403FE36 RID: 261686
		[Token(Token = "0x403FE36")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objUnlockTips;

		// Token: 0x0403FE37 RID: 261687
		[Token(Token = "0x403FE37")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _relicCount;

		// Token: 0x0403FE38 RID: 261688
		[Token(Token = "0x403FE38")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textChooseTip;

		// Token: 0x0403FE39 RID: 261689
		[Token(Token = "0x403FE39")]
		[FieldOffset(Offset = "0x68")]
		private Act12D6RelicHandBookStateBean m_cachedBean;

		// Token: 0x0403FE3A RID: 261690
		[Token(Token = "0x403FE3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FE3B RID: 261691
		[Token(Token = "0x403FE3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderEmptyDetailPart;

		// Token: 0x0403FE3C RID: 261692
		[Token(Token = "0x403FE3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDetailPart;

		// Token: 0x0403FE3D RID: 261693
		[Token(Token = "0x403FE3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenerateRelicProgress;

		// Token: 0x0403FE3E RID: 261694
		[Token(Token = "0x403FE3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
