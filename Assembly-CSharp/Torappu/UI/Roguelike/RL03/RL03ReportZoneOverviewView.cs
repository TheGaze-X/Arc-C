using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200582B RID: 22571
	[Token(Token = "0x200582B")]
	public class RL03ReportZoneOverviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020FAA RID: 135082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FAA")]
		[Address(RVA = "0x1B4F060", Offset = "0x1B4DC60", VA = "0x181B4F060")]
		public RL03ReportZoneOverviewView()
		{
		}

		// Token: 0x0402CD98 RID: 183704
		[Token(Token = "0x402CD98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIAtlasImage> _zoneIconList;

		// Token: 0x0402CD99 RID: 183705
		[Token(Token = "0x402CD99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _objCheckerList;

		// Token: 0x0402CD9A RID: 183706
		[Token(Token = "0x402CD9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIAtlasImage> _zoneIconNameList;

		// Token: 0x0402CD9B RID: 183707
		[Token(Token = "0x402CD9B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _prefabHeight;

		// Token: 0x0402CD9C RID: 183708
		[Token(Token = "0x402CD9C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nameFadeOutAlpha;

		// Token: 0x0402CD9D RID: 183709
		[Token(Token = "0x402CD9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200582C RID: 22572
		[Token(Token = "0x200582C")]
		public class VirtualView : BasicReportItem<RL03ReportZoneOverviewView>
		{
			// Token: 0x06020FAB RID: 135083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FAB")]
			[Address(RVA = "0x1B5A600", Offset = "0x1B59200", VA = "0x181B5A600")]
			public void SetParams(List<SpriteRenderData> zoneIcons, List<SpriteRenderData> zoneNames)
			{
			}

			// Token: 0x06020FAC RID: 135084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FAC")]
			[Address(RVA = "0x1B5A7E0", Offset = "0x1B593E0", VA = "0x181B5A7E0")]
			public VirtualView(RL03ReportZoneOverviewView prefab)
			{
			}

			// Token: 0x06020FAD RID: 135085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020FAD")]
			[Address(RVA = "0x1B59700", Offset = "0x1B58300", VA = "0x181B59700", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06020FAE RID: 135086 RVA: 0x000B80E0 File Offset: 0x000B62E0
			[Token(Token = "0x6020FAE")]
			[Address(RVA = "0x1B59770", Offset = "0x1B58370", VA = "0x181B59770", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06020FAF RID: 135087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FAF")]
			[Address(RVA = "0x1B59DA0", Offset = "0x1B589A0", VA = "0x181B59DA0", Slot = "14")]
			protected override void OnRenderView(RL03ReportZoneOverviewView view)
			{
			}

			// Token: 0x0402CD9E RID: 183710
			[Token(Token = "0x402CD9E")]
			[FieldOffset(Offset = "0x20")]
			private RL03ReportZoneOverviewView m_prefab;

			// Token: 0x0402CD9F RID: 183711
			[Token(Token = "0x402CD9F")]
			[FieldOffset(Offset = "0x28")]
			private List<SpriteRenderData> m_zoneIcons;

			// Token: 0x0402CDA0 RID: 183712
			[Token(Token = "0x402CDA0")]
			[FieldOffset(Offset = "0x30")]
			private List<SpriteRenderData> m_zoneNames;

			// Token: 0x0402CDA1 RID: 183713
			[Token(Token = "0x402CDA1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetParams;

			// Token: 0x0402CDA2 RID: 183714
			[Token(Token = "0x402CDA2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CDA3 RID: 183715
			[Token(Token = "0x402CDA3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402CDA4 RID: 183716
			[Token(Token = "0x402CDA4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402CDA5 RID: 183717
			[Token(Token = "0x402CDA5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
