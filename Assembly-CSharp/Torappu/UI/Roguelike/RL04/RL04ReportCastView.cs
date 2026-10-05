using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056AD RID: 22189
	[Token(Token = "0x20056AD")]
	public class RL04ReportCastView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060208AB RID: 133291 RVA: 0x000B65C8 File Offset: 0x000B47C8
		[Token(Token = "0x60208AB")]
		[Address(RVA = "0x1AB2610", Offset = "0x1AB1210", VA = "0x181AB2610")]
		public float PrefabOnlyCalcHeight(string nameStr)
		{
			return 0f;
		}

		// Token: 0x060208AC RID: 133292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208AC")]
		[Address(RVA = "0x1AB27C0", Offset = "0x1AB13C0", VA = "0x181AB27C0")]
		public RL04ReportCastView()
		{
		}

		// Token: 0x0402C174 RID: 180596
		[Token(Token = "0x402C174")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCast;

		// Token: 0x0402C175 RID: 180597
		[Token(Token = "0x402C175")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _padding;

		// Token: 0x0402C176 RID: 180598
		[Token(Token = "0x402C176")]
		[FieldOffset(Offset = "0x28")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402C177 RID: 180599
		[Token(Token = "0x402C177")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402C178 RID: 180600
		[Token(Token = "0x402C178")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrefabOnlyCalcHeight;

		// Token: 0x0402C179 RID: 180601
		[Token(Token = "0x402C179")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056AE RID: 22190
		[Token(Token = "0x20056AE")]
		public class VirtualView : BasicReportItem<RL04ReportCastView>
		{
			// Token: 0x17004C3D RID: 19517
			// (get) Token: 0x060208AD RID: 133293 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060208AE RID: 133294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C3D")]
			public string castNames
			{
				[Token(Token = "0x60208AD")]
				[Address(RVA = "0x1AB9DD0", Offset = "0x1AB89D0", VA = "0x181AB9DD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60208AE")]
				[Address(RVA = "0x1AB9E30", Offset = "0x1AB8A30", VA = "0x181AB9E30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060208AF RID: 133295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60208AF")]
			[Address(RVA = "0x1AB98A0", Offset = "0x1AB84A0", VA = "0x181AB98A0")]
			public void SetNamesWithList(IEnumerator<string> nameIter)
			{
			}

			// Token: 0x060208B0 RID: 133296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60208B0")]
			[Address(RVA = "0x1AB9BD0", Offset = "0x1AB87D0", VA = "0x181AB9BD0")]
			public VirtualView(RL04ReportCastView prefab)
			{
			}

			// Token: 0x060208B1 RID: 133297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60208B1")]
			[Address(RVA = "0x1AB9270", Offset = "0x1AB7E70", VA = "0x181AB9270", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060208B2 RID: 133298 RVA: 0x000B65E0 File Offset: 0x000B47E0
			[Token(Token = "0x60208B2")]
			[Address(RVA = "0x1AB9350", Offset = "0x1AB7F50", VA = "0x181AB9350", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060208B3 RID: 133299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60208B3")]
			[Address(RVA = "0x1AB97B0", Offset = "0x1AB83B0", VA = "0x181AB97B0", Slot = "14")]
			protected override void OnRenderView(RL04ReportCastView view)
			{
			}

			// Token: 0x0402C17A RID: 180602
			[Token(Token = "0x402C17A")]
			[FieldOffset(Offset = "0x20")]
			private RL04ReportCastView m_prefab;

			// Token: 0x0402C17B RID: 180603
			[Token(Token = "0x402C17B")]
			[FieldOffset(Offset = "0x28")]
			private float m_cachedHeight;

			// Token: 0x0402C17D RID: 180605
			[Token(Token = "0x402C17D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_castNames;

			// Token: 0x0402C17E RID: 180606
			[Token(Token = "0x402C17E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_castNames;

			// Token: 0x0402C17F RID: 180607
			[Token(Token = "0x402C17F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetNamesWithList;

			// Token: 0x0402C180 RID: 180608
			[Token(Token = "0x402C180")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C181 RID: 180609
			[Token(Token = "0x402C181")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402C182 RID: 180610
			[Token(Token = "0x402C182")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402C183 RID: 180611
			[Token(Token = "0x402C183")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
