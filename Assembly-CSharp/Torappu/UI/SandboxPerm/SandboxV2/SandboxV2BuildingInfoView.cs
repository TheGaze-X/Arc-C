using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004116 RID: 16662
	[Token(Token = "0x2004116")]
	public class SandboxV2BuildingInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C06 RID: 105478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C06")]
		[Address(RVA = "0x1296C20", Offset = "0x1295820", VA = "0x181296C20")]
		public void Render(SandboxV2DungeonBuildingTrapInfo buildingTrapInfo, int index, string nodeTypeName)
		{
		}

		// Token: 0x06019C07 RID: 105479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C07")]
		[Address(RVA = "0x1296EF0", Offset = "0x1295AF0", VA = "0x181296EF0")]
		public SandboxV2BuildingInfoView()
		{
		}

		// Token: 0x0402044C RID: 132172
		[Token(Token = "0x402044C")]
		private const string BUILDING_COUNT_FORMAT = "{0}<color=#4a4a4a>/{1}</color>";

		// Token: 0x0402044D RID: 132173
		[Token(Token = "0x402044D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nodeName;

		// Token: 0x0402044E RID: 132174
		[Token(Token = "0x402044E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buildingName;

		// Token: 0x0402044F RID: 132175
		[Token(Token = "0x402044F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _damagedIconGameObject;

		// Token: 0x04020450 RID: 132176
		[Token(Token = "0x4020450")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _upgradeIconGameObject;

		// Token: 0x04020451 RID: 132177
		[Token(Token = "0x4020451")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _playerHoldCount;

		// Token: 0x04020452 RID: 132178
		[Token(Token = "0x4020452")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _bgImageGameObject;

		// Token: 0x04020453 RID: 132179
		[Token(Token = "0x4020453")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlTitle;

		// Token: 0x04020454 RID: 132180
		[Token(Token = "0x4020454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020455 RID: 132181
		[Token(Token = "0x4020455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004117 RID: 16663
		[Token(Token = "0x2004117")]
		public class Param
		{
			// Token: 0x06019C08 RID: 105480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C08")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04020456 RID: 132182
			[Token(Token = "0x4020456")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2BuildingInfoView prefab;

			// Token: 0x04020457 RID: 132183
			[Token(Token = "0x4020457")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2DungeonBuildingTrapInfo buildingTrapInfo;

			// Token: 0x04020458 RID: 132184
			[Token(Token = "0x4020458")]
			[FieldOffset(Offset = "0x40")]
			public int index;

			// Token: 0x04020459 RID: 132185
			[Token(Token = "0x4020459")]
			[FieldOffset(Offset = "0x44")]
			public float preferredHeightWithTitle;

			// Token: 0x0402045A RID: 132186
			[Token(Token = "0x402045A")]
			[FieldOffset(Offset = "0x48")]
			public float preferredHeightWithoutTitle;

			// Token: 0x0402045B RID: 132187
			[Token(Token = "0x402045B")]
			[FieldOffset(Offset = "0x50")]
			public string nodeTypeName;
		}

		// Token: 0x02004118 RID: 16664
		[Token(Token = "0x2004118")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<SandboxV2BuildingInfoView>
		{
			// Token: 0x06019C09 RID: 105481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C09")]
			[Address(RVA = "0x12A0470", Offset = "0x129F070", VA = "0x1812A0470")]
			public VirtualView(SandboxV2BuildingInfoView.Param param)
			{
			}

			// Token: 0x06019C0A RID: 105482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C0A")]
			[Address(RVA = "0x12A0260", Offset = "0x129EE60", VA = "0x1812A0260", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06019C0B RID: 105483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C0B")]
			[Address(RVA = "0x12A0380", Offset = "0x129EF80", VA = "0x1812A0380", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06019C0C RID: 105484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019C0C")]
			[Address(RVA = "0x12A0000", Offset = "0x129EC00", VA = "0x1812A0000", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06019C0D RID: 105485 RVA: 0x0009F4E0 File Offset: 0x0009D6E0
			[Token(Token = "0x6019C0D")]
			[Address(RVA = "0x12A00E0", Offset = "0x129ECE0", VA = "0x1812A00E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402045C RID: 132188
			[Token(Token = "0x402045C")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2BuildingInfoView.Param m_param;

			// Token: 0x0402045D RID: 132189
			[Token(Token = "0x402045D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402045E RID: 132190
			[Token(Token = "0x402045E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402045F RID: 132191
			[Token(Token = "0x402045F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04020460 RID: 132192
			[Token(Token = "0x4020460")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04020461 RID: 132193
			[Token(Token = "0x4020461")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
