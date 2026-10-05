using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004264 RID: 16996
	[Token(Token = "0x2004264")]
	public class SandboxV2NodeViewPortable : SandboxV2AbstractNodeView
	{
		// Token: 0x0601A317 RID: 107287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A317")]
		[Address(RVA = "0x1322EA0", Offset = "0x1321AA0", VA = "0x181322EA0", Slot = "7")]
		protected override void DoOnRecycle()
		{
		}

		// Token: 0x0601A318 RID: 107288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A318")]
		[Address(RVA = "0x1322F30", Offset = "0x1321B30", VA = "0x181322F30", Slot = "9")]
		protected override void DoRenderBasicData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A319 RID: 107289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A319")]
		[Address(RVA = "0x1323060", Offset = "0x1321C60", VA = "0x181323060", Slot = "10")]
		protected override void DoRenderData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A31A RID: 107290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A31A")]
		[Address(RVA = "0x13236A0", Offset = "0x13222A0", VA = "0x1813236A0")]
		private void _RenderWeatherIcon(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A31B RID: 107291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A31B")]
		[Address(RVA = "0x13235B0", Offset = "0x13221B0", VA = "0x1813235B0", Slot = "11")]
		protected override SandboxV2EnterAnimTween InitEnterAnim(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
			return null;
		}

		// Token: 0x0601A31C RID: 107292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A31C")]
		[Address(RVA = "0x1323900", Offset = "0x1322500", VA = "0x181323900")]
		public SandboxV2NodeViewPortable()
		{
		}

		// Token: 0x0601A31E RID: 107294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A31E")]
		[Address(RVA = "0x1322E20", Offset = "0x1321A20", VA = "0x181322E20")]
		private void <>xLuaBaseProxy_DoOnRecycle()
		{
		}

		// Token: 0x0601A31F RID: 107295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A31F")]
		[Address(RVA = "0x1316E30", Offset = "0x1315A30", VA = "0x181316E30")]
		private void <>xLuaBaseProxy_DoRenderBasicData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x0601A320 RID: 107296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A320")]
		[Address(RVA = "0x1316EB0", Offset = "0x1315AB0", VA = "0x181316EB0")]
		private void <>xLuaBaseProxy_DoRenderData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x040211F3 RID: 135667
		[Token(Token = "0x40211F3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ConstructTipType[] CONCERNED_TIPS;

		// Token: 0x040211F4 RID: 135668
		[Token(Token = "0x40211F4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Image _imgWeatherIcon;

		// Token: 0x040211F5 RID: 135669
		[Token(Token = "0x40211F5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _textNodeType;

		// Token: 0x040211F6 RID: 135670
		[Token(Token = "0x40211F6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textNodeName;

		// Token: 0x040211F7 RID: 135671
		[Token(Token = "0x40211F7")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SandboxV2CircleProgressBar _progressBar;

		// Token: 0x040211F8 RID: 135672
		[Token(Token = "0x40211F8")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAtlasImage _imgTips;

		// Token: 0x040211F9 RID: 135673
		[Token(Token = "0x40211F9")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040211FA RID: 135674
		[Token(Token = "0x40211FA")]
		[FieldOffset(Offset = "0x120")]
		private string m_cachedWeatherId;

		// Token: 0x040211FB RID: 135675
		[Token(Token = "0x40211FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoOnRecycle;

		// Token: 0x040211FC RID: 135676
		[Token(Token = "0x40211FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoRenderBasicData;

		// Token: 0x040211FD RID: 135677
		[Token(Token = "0x40211FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoRenderData;

		// Token: 0x040211FE RID: 135678
		[Token(Token = "0x40211FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderWeatherIcon;

		// Token: 0x040211FF RID: 135679
		[Token(Token = "0x40211FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitEnterAnim;

		// Token: 0x04021200 RID: 135680
		[Token(Token = "0x4021200")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
