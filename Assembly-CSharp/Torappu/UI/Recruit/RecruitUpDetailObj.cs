using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200474E RID: 18254
	[Token(Token = "0x200474E")]
	public class RecruitUpDetailObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA48 RID: 113224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA48")]
		[Address(RVA = "0x1505810", Offset = "0x1504410", VA = "0x181505810")]
		public void Render(GachaDetailData.GachaUpChar.GachaPerChar upCharList, bool isEnd, bool isPortrait, [Optional] List<string> limitList)
		{
		}

		// Token: 0x0601BA49 RID: 113225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA49")]
		[Address(RVA = "0x1505BC0", Offset = "0x15047C0", VA = "0x181505BC0")]
		public void Render(GachaDetailData.GachaAvailChar.GachaPerAvail perObj, bool isEnd, RecruitAvailDetailPickUpPart.Options option, bool isPortrait, string recruit6StarHint)
		{
		}

		// Token: 0x0601BA4A RID: 113226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA4A")]
		[Address(RVA = "0x1505430", Offset = "0x1504030", VA = "0x181505430")]
		public void RenderWeightUpChar(List<GachaDetailData.GachaWeightUpChar> weightUpCharList, float percent)
		{
		}

		// Token: 0x0601BA4B RID: 113227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA4B")]
		[Address(RVA = "0x1505F60", Offset = "0x1504B60", VA = "0x181505F60")]
		private void _Render6StarHint(bool showFlag, string recruit6StarHint)
		{
		}

		// Token: 0x0601BA4C RID: 113228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA4C")]
		[Address(RVA = "0x15060A0", Offset = "0x1504CA0", VA = "0x1815060A0")]
		public RecruitUpDetailObj()
		{
		}

		// Token: 0x04023DD5 RID: 146901
		[Token(Token = "0x4023DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _starSprite;

		// Token: 0x04023DD6 RID: 146902
		[Token(Token = "0x4023DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023DD7 RID: 146903
		[Token(Token = "0x4023DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecruitCharDetailObj _charObj;

		// Token: 0x04023DD8 RID: 146904
		[Token(Token = "0x4023DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RecruitUpCharDetailPortraitObj _portraitObj;

		// Token: 0x04023DD9 RID: 146905
		[Token(Token = "0x4023DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _title;

		// Token: 0x04023DDA RID: 146906
		[Token(Token = "0x4023DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _endLine;

		// Token: 0x04023DDB RID: 146907
		[Token(Token = "0x4023DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _security6;

		// Token: 0x04023DDC RID: 146908
		[Token(Token = "0x4023DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _security5;

		// Token: 0x04023DDD RID: 146909
		[Token(Token = "0x4023DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _textDetail;

		// Token: 0x04023DDE RID: 146910
		[Token(Token = "0x4023DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDetailLabel;

		// Token: 0x04023DDF RID: 146911
		[Token(Token = "0x4023DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DE0 RID: 146912
		[Token(Token = "0x4023DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x04023DE1 RID: 146913
		[Token(Token = "0x4023DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderWeightUpChar;

		// Token: 0x04023DE2 RID: 146914
		[Token(Token = "0x4023DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render6StarHint;

		// Token: 0x04023DE3 RID: 146915
		[Token(Token = "0x4023DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
