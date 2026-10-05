using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057B6 RID: 22454
	[Token(Token = "0x20057B6")]
	public class RL01ReportCastView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020D65 RID: 134501 RVA: 0x000B7840 File Offset: 0x000B5A40
		[Token(Token = "0x6020D65")]
		[Address(RVA = "0x1B1C490", Offset = "0x1B1B090", VA = "0x181B1C490")]
		public float PrefabOnlyCalcHeight(string left, string right)
		{
			return 0f;
		}

		// Token: 0x06020D66 RID: 134502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D66")]
		[Address(RVA = "0x1B1C6C0", Offset = "0x1B1B2C0", VA = "0x181B1C6C0")]
		public RL01ReportCastView()
		{
		}

		// Token: 0x0402C9EF RID: 182767
		[Token(Token = "0x402C9EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLeft;

		// Token: 0x0402C9F0 RID: 182768
		[Token(Token = "0x402C9F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRight;

		// Token: 0x0402C9F1 RID: 182769
		[Token(Token = "0x402C9F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _padding;

		// Token: 0x0402C9F2 RID: 182770
		[Token(Token = "0x402C9F2")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402C9F3 RID: 182771
		[Token(Token = "0x402C9F3")]
		[FieldOffset(Offset = "0x38")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402C9F4 RID: 182772
		[Token(Token = "0x402C9F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrefabOnlyCalcHeight;

		// Token: 0x0402C9F5 RID: 182773
		[Token(Token = "0x402C9F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057B7 RID: 22455
		[Token(Token = "0x20057B7")]
		public class VirtualView : BasicReportItem<RL01ReportCastView>
		{
			// Token: 0x17004CFD RID: 19709
			// (get) Token: 0x06020D67 RID: 134503 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020D68 RID: 134504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CFD")]
			public string leftNames
			{
				[Token(Token = "0x6020D67")]
				[Address(RVA = "0x1B2D420", Offset = "0x1B2C020", VA = "0x181B2D420")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020D68")]
				[Address(RVA = "0x1B2D4E0", Offset = "0x1B2C0E0", VA = "0x181B2D4E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004CFE RID: 19710
			// (get) Token: 0x06020D69 RID: 134505 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020D6A RID: 134506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CFE")]
			public string rightNames
			{
				[Token(Token = "0x6020D69")]
				[Address(RVA = "0x1B2D480", Offset = "0x1B2C080", VA = "0x181B2D480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020D6A")]
				[Address(RVA = "0x1B2D560", Offset = "0x1B2C160", VA = "0x181B2D560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06020D6B RID: 134507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D6B")]
			[Address(RVA = "0x1B2CF30", Offset = "0x1B2BB30", VA = "0x181B2CF30")]
			public void SetNamesWithList(IEnumerator<string> nameIter)
			{
			}

			// Token: 0x06020D6C RID: 134508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D6C")]
			[Address(RVA = "0x1B2D2D0", Offset = "0x1B2BED0", VA = "0x181B2D2D0")]
			public VirtualView(RL01ReportCastView prefab)
			{
			}

			// Token: 0x06020D6D RID: 134509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D6D")]
			[Address(RVA = "0x1B2C970", Offset = "0x1B2B570", VA = "0x181B2C970", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06020D6E RID: 134510 RVA: 0x000B7858 File Offset: 0x000B5A58
			[Token(Token = "0x6020D6E")]
			[Address(RVA = "0x1B2CA60", Offset = "0x1B2B660", VA = "0x181B2CA60", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06020D6F RID: 134511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D6F")]
			[Address(RVA = "0x1B2CDA0", Offset = "0x1B2B9A0", VA = "0x181B2CDA0", Slot = "14")]
			protected override void OnRenderView(RL01ReportCastView view)
			{
			}

			// Token: 0x0402C9F6 RID: 182774
			[Token(Token = "0x402C9F6")]
			[FieldOffset(Offset = "0x20")]
			private RL01ReportCastView m_prefab;

			// Token: 0x0402C9F7 RID: 182775
			[Token(Token = "0x402C9F7")]
			[FieldOffset(Offset = "0x28")]
			private float m_cachedHeight;

			// Token: 0x0402C9FA RID: 182778
			[Token(Token = "0x402C9FA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_leftNames;

			// Token: 0x0402C9FB RID: 182779
			[Token(Token = "0x402C9FB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_leftNames;

			// Token: 0x0402C9FC RID: 182780
			[Token(Token = "0x402C9FC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_rightNames;

			// Token: 0x0402C9FD RID: 182781
			[Token(Token = "0x402C9FD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_rightNames;

			// Token: 0x0402C9FE RID: 182782
			[Token(Token = "0x402C9FE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetNamesWithList;

			// Token: 0x0402C9FF RID: 182783
			[Token(Token = "0x402C9FF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CA00 RID: 182784
			[Token(Token = "0x402CA00")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402CA01 RID: 182785
			[Token(Token = "0x402CA01")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402CA02 RID: 182786
			[Token(Token = "0x402CA02")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
