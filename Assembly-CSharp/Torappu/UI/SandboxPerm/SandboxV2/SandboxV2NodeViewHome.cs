using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004261 RID: 16993
	[Token(Token = "0x2004261")]
	public class SandboxV2NodeViewHome : SandboxV2AbstractNodeView
	{
		// Token: 0x0601A2FE RID: 107262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2FE")]
		[Address(RVA = "0x1322730", Offset = "0x1321330", VA = "0x181322730", Slot = "6")]
		protected override void DoOnInit()
		{
		}

		// Token: 0x0601A2FF RID: 107263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2FF")]
		[Address(RVA = "0x1322840", Offset = "0x1321440", VA = "0x181322840", Slot = "7")]
		protected override void DoOnRecycle()
		{
		}

		// Token: 0x0601A300 RID: 107264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A300")]
		[Address(RVA = "0x1322C10", Offset = "0x1321810", VA = "0x181322C10", Slot = "8")]
		protected override void DoRenderPermanentData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A301 RID: 107265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A301")]
		[Address(RVA = "0x13228D0", Offset = "0x13214D0", VA = "0x1813228D0", Slot = "10")]
		protected override void DoRenderData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A302 RID: 107266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A302")]
		[Address(RVA = "0x1322D10", Offset = "0x1321910", VA = "0x181322D10", Slot = "11")]
		protected override SandboxV2EnterAnimTween InitEnterAnim(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
			return null;
		}

		// Token: 0x0601A303 RID: 107267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A303")]
		[Address(RVA = "0x1322E40", Offset = "0x1321A40", VA = "0x181322E40")]
		public SandboxV2NodeViewHome()
		{
		}

		// Token: 0x0601A304 RID: 107268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A304")]
		[Address(RVA = "0x1322E10", Offset = "0x1321A10", VA = "0x181322E10")]
		private void <>xLuaBaseProxy_DoOnInit()
		{
		}

		// Token: 0x0601A305 RID: 107269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A305")]
		[Address(RVA = "0x1322E20", Offset = "0x1321A20", VA = "0x181322E20")]
		private void <>xLuaBaseProxy_DoOnRecycle()
		{
		}

		// Token: 0x0601A306 RID: 107270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A306")]
		[Address(RVA = "0x1322E30", Offset = "0x1321A30", VA = "0x181322E30")]
		private void <>xLuaBaseProxy_DoRenderPermanentData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x0601A307 RID: 107271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A307")]
		[Address(RVA = "0x1316EB0", Offset = "0x1315AB0", VA = "0x181316EB0")]
		private void <>xLuaBaseProxy_DoRenderData(SandboxV2DungeonNodeViewModel P0, SandboxV2DungeonViewModel P1)
		{
		}

		// Token: 0x040211D6 RID: 135638
		[Token(Token = "0x40211D6")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _connectorPrefab;

		// Token: 0x040211D7 RID: 135639
		[Token(Token = "0x40211D7")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _connectorContainer;

		// Token: 0x040211D8 RID: 135640
		[Token(Token = "0x40211D8")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SandboxV2CircleProgressBar _progressBar;

		// Token: 0x040211D9 RID: 135641
		[Token(Token = "0x40211D9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAtlasImage _imgTips;

		// Token: 0x040211DA RID: 135642
		[Token(Token = "0x40211DA")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<SandboxV2ConstructTipType> concernedTips;

		// Token: 0x040211DB RID: 135643
		[Token(Token = "0x40211DB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIAnimationLocation _enterAnimNormal;

		// Token: 0x040211DC RID: 135644
		[Token(Token = "0x40211DC")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIAnimationLocation _enterAnimChallenge;

		// Token: 0x040211DD RID: 135645
		[Token(Token = "0x40211DD")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<string, string> m_cachedConnection;

		// Token: 0x040211DE RID: 135646
		[Token(Token = "0x40211DE")]
		[FieldOffset(Offset = "0x138")]
		private SandboxV2DungeonViewModel m_cachedDungeonViewModel;

		// Token: 0x040211DF RID: 135647
		[Token(Token = "0x40211DF")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2DungeonNodeViewModel m_cachedNodeViewModel;

		// Token: 0x040211E0 RID: 135648
		[Token(Token = "0x40211E0")]
		[FieldOffset(Offset = "0x148")]
		private SandboxV2NodeViewHome.ConnectorPool m_connectorPool;

		// Token: 0x040211E1 RID: 135649
		[Token(Token = "0x40211E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoOnInit;

		// Token: 0x040211E2 RID: 135650
		[Token(Token = "0x40211E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoOnRecycle;

		// Token: 0x040211E3 RID: 135651
		[Token(Token = "0x40211E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoRenderPermanentData;

		// Token: 0x040211E4 RID: 135652
		[Token(Token = "0x40211E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoRenderData;

		// Token: 0x040211E5 RID: 135653
		[Token(Token = "0x40211E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitEnterAnim;

		// Token: 0x040211E6 RID: 135654
		[Token(Token = "0x40211E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004262 RID: 16994
		[Token(Token = "0x2004262")]
		private class ConnectorPool : GameObjectDictPool<RectTransform>
		{
			// Token: 0x0601A308 RID: 107272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A308")]
			[Address(RVA = "0x1314A10", Offset = "0x1313610", VA = "0x181314A10")]
			public ConnectorPool(SandboxV2NodeViewHome closure)
			{
			}

			// Token: 0x0601A309 RID: 107273 RVA: 0x000A0740 File Offset: 0x0009E940
			[Token(Token = "0x601A309")]
			[Address(RVA = "0x1314530", Offset = "0x1313130", VA = "0x181314530", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x0601A30A RID: 107274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A30A")]
			[Address(RVA = "0x1314800", Offset = "0x1313400", VA = "0x181314800", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x0601A30B RID: 107275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A30B")]
			[Address(RVA = "0x1314660", Offset = "0x1313260", VA = "0x181314660", Slot = "7")]
			protected override RectTransform GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x0601A30C RID: 107276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A30C")]
			[Address(RVA = "0x1314720", Offset = "0x1313320", VA = "0x181314720", Slot = "8")]
			protected override RectTransform Instantiate(string key, RectTransform prefab)
			{
				return null;
			}

			// Token: 0x0601A30D RID: 107277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A30D")]
			[Address(RVA = "0x13148B0", Offset = "0x13134B0", VA = "0x1813148B0", Slot = "9")]
			protected override void Render(string key, RectTransform obj)
			{
			}

			// Token: 0x040211E7 RID: 135655
			[Token(Token = "0x40211E7")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2NodeViewHome m_closure;

			// Token: 0x040211E8 RID: 135656
			[Token(Token = "0x40211E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040211E9 RID: 135657
			[Token(Token = "0x40211E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x040211EA RID: 135658
			[Token(Token = "0x40211EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x040211EB RID: 135659
			[Token(Token = "0x40211EB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040211EC RID: 135660
			[Token(Token = "0x40211EC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x040211ED RID: 135661
			[Token(Token = "0x40211ED")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
