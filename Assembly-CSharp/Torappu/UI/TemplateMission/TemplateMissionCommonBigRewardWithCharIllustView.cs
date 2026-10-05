using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D91 RID: 15761
	[Token(Token = "0x2003D91")]
	public class TemplateMissionCommonBigRewardWithCharIllustView : TemplateMissionCommonBigRewardIllustView
	{
		// Token: 0x0601883E RID: 100414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883E")]
		[Address(RVA = "0x110A070", Offset = "0x1108C70", VA = "0x18110A070", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x0601883F RID: 100415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883F")]
		[Address(RVA = "0x110A250", Offset = "0x1108E50", VA = "0x18110A250", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x06018840 RID: 100416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018840")]
		[Address(RVA = "0x110A600", Offset = "0x1109200", VA = "0x18110A600")]
		private string _GetCharId(List<string> paramList)
		{
			return null;
		}

		// Token: 0x06018841 RID: 100417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018841")]
		[Address(RVA = "0x110A890", Offset = "0x1109490", VA = "0x18110A890")]
		private void _RenderCharDataPart(string charId)
		{
		}

		// Token: 0x06018842 RID: 100418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018842")]
		[Address(RVA = "0x110A950", Offset = "0x1109550", VA = "0x18110A950")]
		private void _RenderCharInfo(string charId)
		{
		}

		// Token: 0x06018843 RID: 100419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018843")]
		[Address(RVA = "0x110AEC0", Offset = "0x1109AC0", VA = "0x18110AEC0")]
		private void _RenderTipsPart(List<string> paramList)
		{
		}

		// Token: 0x06018844 RID: 100420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018844")]
		[Address(RVA = "0x110ABF0", Offset = "0x11097F0", VA = "0x18110ABF0")]
		private void _RenderPortraitPhase2Color(List<string> paramList)
		{
		}

		// Token: 0x06018845 RID: 100421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018845")]
		[Address(RVA = "0x110A6D0", Offset = "0x11092D0", VA = "0x18110A6D0")]
		private void _RefreshPortraitPhaseMat(UICharacterIllust illust, Color color)
		{
		}

		// Token: 0x06018846 RID: 100422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018846")]
		[Address(RVA = "0x110A150", Offset = "0x1108D50", VA = "0x18110A150")]
		public void OnDetailInfoClick()
		{
		}

		// Token: 0x06018847 RID: 100423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018847")]
		[Address(RVA = "0x110B000", Offset = "0x1109C00", VA = "0x18110B000")]
		public TemplateMissionCommonBigRewardWithCharIllustView()
		{
		}

		// Token: 0x06018848 RID: 100424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018848")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E0C7 RID: 123079
		[Token(Token = "0x401E0C7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Illust Part")]
		private GameObject _objIllustPart;

		// Token: 0x0401E0C8 RID: 123080
		[Token(Token = "0x401E0C8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Illust Part")]
		private RectTransform _rectTransformIllust1;

		// Token: 0x0401E0C9 RID: 123081
		[Token(Token = "0x401E0C9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Illust Part")]
		private RectTransform _rectTransformIllust2;

		// Token: 0x0401E0CA RID: 123082
		[Token(Token = "0x401E0CA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Illust Part")]
		private Material _materialForIllust2;

		// Token: 0x0401E0CB RID: 123083
		[Token(Token = "0x401E0CB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Illust Part")]
		private float _alphaForIllust2;

		// Token: 0x0401E0CC RID: 123084
		[Token(Token = "0x401E0CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Char Info Part")]
		private GameObject _objCharInfoPart;

		// Token: 0x0401E0CD RID: 123085
		[Token(Token = "0x401E0CD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Char Info Part")]
		private Image _profession;

		// Token: 0x0401E0CE RID: 123086
		[Token(Token = "0x401E0CE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Char Info Part")]
		private Image _rarity;

		// Token: 0x0401E0CF RID: 123087
		[Token(Token = "0x401E0CF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Char Info Part")]
		private Text _nameText;

		// Token: 0x0401E0D0 RID: 123088
		[Token(Token = "0x401E0D0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Tips Part")]
		private GameObject _objTipsPart;

		// Token: 0x0401E0D1 RID: 123089
		[Token(Token = "0x401E0D1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Tips Part")]
		private Text _txtTips;

		// Token: 0x0401E0D2 RID: 123090
		[Token(Token = "0x401E0D2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E0D3 RID: 123091
		[Token(Token = "0x401E0D3")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isRendered;

		// Token: 0x0401E0D4 RID: 123092
		[Token(Token = "0x401E0D4")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedCharId;

		// Token: 0x0401E0D5 RID: 123093
		[Token(Token = "0x401E0D5")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E0D6 RID: 123094
		[Token(Token = "0x401E0D6")]
		[FieldOffset(Offset = "0xD0")]
		private UICharacterIllust m_illust1;

		// Token: 0x0401E0D7 RID: 123095
		[Token(Token = "0x401E0D7")]
		[FieldOffset(Offset = "0xD8")]
		private UICharacterIllust m_illust2;

		// Token: 0x0401E0D8 RID: 123096
		[Token(Token = "0x401E0D8")]
		[FieldOffset(Offset = "0xE0")]
		private Material m_cachedIllust2Mat;

		// Token: 0x0401E0D9 RID: 123097
		[Token(Token = "0x401E0D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E0DA RID: 123098
		[Token(Token = "0x401E0DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E0DB RID: 123099
		[Token(Token = "0x401E0DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCharId;

		// Token: 0x0401E0DC RID: 123100
		[Token(Token = "0x401E0DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCharDataPart;

		// Token: 0x0401E0DD RID: 123101
		[Token(Token = "0x401E0DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCharInfo;

		// Token: 0x0401E0DE RID: 123102
		[Token(Token = "0x401E0DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderTipsPart;

		// Token: 0x0401E0DF RID: 123103
		[Token(Token = "0x401E0DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPortraitPhase2Color;

		// Token: 0x0401E0E0 RID: 123104
		[Token(Token = "0x401E0E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshPortraitPhaseMat;

		// Token: 0x0401E0E1 RID: 123105
		[Token(Token = "0x401E0E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDetailInfoClick;

		// Token: 0x0401E0E2 RID: 123106
		[Token(Token = "0x401E0E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
