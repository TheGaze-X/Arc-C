using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005829 RID: 22569
	[Token(Token = "0x2005829")]
	public class RL03ReportCastView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020FA1 RID: 135073 RVA: 0x000B80B0 File Offset: 0x000B62B0
		[Token(Token = "0x6020FA1")]
		[Address(RVA = "0x1B4EE50", Offset = "0x1B4DA50", VA = "0x181B4EE50")]
		public float PrefabOnlyCalcHeight(string nameStr)
		{
			return 0f;
		}

		// Token: 0x06020FA2 RID: 135074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FA2")]
		[Address(RVA = "0x1B4F000", Offset = "0x1B4DC00", VA = "0x181B4F000")]
		public RL03ReportCastView()
		{
		}

		// Token: 0x0402CD88 RID: 183688
		[Token(Token = "0x402CD88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCast;

		// Token: 0x0402CD89 RID: 183689
		[Token(Token = "0x402CD89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _padding;

		// Token: 0x0402CD8A RID: 183690
		[Token(Token = "0x402CD8A")]
		[FieldOffset(Offset = "0x28")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402CD8B RID: 183691
		[Token(Token = "0x402CD8B")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402CD8C RID: 183692
		[Token(Token = "0x402CD8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrefabOnlyCalcHeight;

		// Token: 0x0402CD8D RID: 183693
		[Token(Token = "0x402CD8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200582A RID: 22570
		[Token(Token = "0x200582A")]
		public class VirtualView : BasicReportItem<RL03ReportCastView>
		{
			// Token: 0x17004D66 RID: 19814
			// (get) Token: 0x06020FA3 RID: 135075 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020FA4 RID: 135076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004D66")]
			public string castNames
			{
				[Token(Token = "0x6020FA3")]
				[Address(RVA = "0x1B5A930", Offset = "0x1B59530", VA = "0x181B5A930")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020FA4")]
				[Address(RVA = "0x1B5A990", Offset = "0x1B59590", VA = "0x181B5A990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06020FA5 RID: 135077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FA5")]
			[Address(RVA = "0x1B5A2D0", Offset = "0x1B58ED0", VA = "0x181B5A2D0")]
			public void SetNamesWithList(IEnumerator<string> nameIter)
			{
			}

			// Token: 0x06020FA6 RID: 135078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FA6")]
			[Address(RVA = "0x1B5A750", Offset = "0x1B59350", VA = "0x181B5A750")]
			public VirtualView(RL03ReportCastView prefab)
			{
			}

			// Token: 0x06020FA7 RID: 135079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020FA7")]
			[Address(RVA = "0x1B59690", Offset = "0x1B58290", VA = "0x181B59690", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06020FA8 RID: 135080 RVA: 0x000B80C8 File Offset: 0x000B62C8
			[Token(Token = "0x6020FA8")]
			[Address(RVA = "0x1B597E0", Offset = "0x1B583E0", VA = "0x181B597E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06020FA9 RID: 135081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020FA9")]
			[Address(RVA = "0x1B59CB0", Offset = "0x1B588B0", VA = "0x181B59CB0", Slot = "14")]
			protected override void OnRenderView(RL03ReportCastView view)
			{
			}

			// Token: 0x0402CD8E RID: 183694
			[Token(Token = "0x402CD8E")]
			[FieldOffset(Offset = "0x20")]
			private RL03ReportCastView m_prefab;

			// Token: 0x0402CD8F RID: 183695
			[Token(Token = "0x402CD8F")]
			[FieldOffset(Offset = "0x28")]
			private float m_cachedHeight;

			// Token: 0x0402CD91 RID: 183697
			[Token(Token = "0x402CD91")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_castNames;

			// Token: 0x0402CD92 RID: 183698
			[Token(Token = "0x402CD92")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_castNames;

			// Token: 0x0402CD93 RID: 183699
			[Token(Token = "0x402CD93")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetNamesWithList;

			// Token: 0x0402CD94 RID: 183700
			[Token(Token = "0x402CD94")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CD95 RID: 183701
			[Token(Token = "0x402CD95")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402CD96 RID: 183702
			[Token(Token = "0x402CD96")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402CD97 RID: 183703
			[Token(Token = "0x402CD97")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
