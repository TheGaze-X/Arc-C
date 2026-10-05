using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055C5 RID: 21957
	[Token(Token = "0x20055C5")]
	public class RL05ReportCastView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060203A5 RID: 132005 RVA: 0x000B4FA8 File Offset: 0x000B31A8
		[Token(Token = "0x60203A5")]
		[Address(RVA = "0x1A58BC0", Offset = "0x1A577C0", VA = "0x181A58BC0")]
		public float PrefabOnlyCalcHeight(string nameStr)
		{
			return 0f;
		}

		// Token: 0x060203A6 RID: 132006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203A6")]
		[Address(RVA = "0x1A58D70", Offset = "0x1A57970", VA = "0x181A58D70")]
		public RL05ReportCastView()
		{
		}

		// Token: 0x0402B987 RID: 178567
		[Token(Token = "0x402B987")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCast;

		// Token: 0x0402B988 RID: 178568
		[Token(Token = "0x402B988")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _padding;

		// Token: 0x0402B989 RID: 178569
		[Token(Token = "0x402B989")]
		[FieldOffset(Offset = "0x28")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402B98A RID: 178570
		[Token(Token = "0x402B98A")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0402B98B RID: 178571
		[Token(Token = "0x402B98B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrefabOnlyCalcHeight;

		// Token: 0x0402B98C RID: 178572
		[Token(Token = "0x402B98C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055C6 RID: 21958
		[Token(Token = "0x20055C6")]
		public class VirtualView : BasicReportItem<RL05ReportCastView>
		{
			// Token: 0x17004B8D RID: 19341
			// (get) Token: 0x060203A7 RID: 132007 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060203A8 RID: 132008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004B8D")]
			public string castNames
			{
				[Token(Token = "0x60203A7")]
				[Address(RVA = "0x1A5DDA0", Offset = "0x1A5C9A0", VA = "0x181A5DDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60203A8")]
				[Address(RVA = "0x1A5DE00", Offset = "0x1A5CA00", VA = "0x181A5DE00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060203A9 RID: 132009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60203A9")]
			[Address(RVA = "0x1A5D9E0", Offset = "0x1A5C5E0", VA = "0x181A5D9E0")]
			public void SetNamesWithList(IEnumerator<string> nameIter)
			{
			}

			// Token: 0x060203AA RID: 132010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60203AA")]
			[Address(RVA = "0x1A5DD10", Offset = "0x1A5C910", VA = "0x181A5DD10")]
			public VirtualView(RL05ReportCastView prefab)
			{
			}

			// Token: 0x060203AB RID: 132011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60203AB")]
			[Address(RVA = "0x1A5D620", Offset = "0x1A5C220", VA = "0x181A5D620", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060203AC RID: 132012 RVA: 0x000B4FC0 File Offset: 0x000B31C0
			[Token(Token = "0x60203AC")]
			[Address(RVA = "0x1A5D690", Offset = "0x1A5C290", VA = "0x181A5D690", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060203AD RID: 132013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60203AD")]
			[Address(RVA = "0x1A5D8F0", Offset = "0x1A5C4F0", VA = "0x181A5D8F0", Slot = "14")]
			protected override void OnRenderView(RL05ReportCastView view)
			{
			}

			// Token: 0x0402B98D RID: 178573
			[Token(Token = "0x402B98D")]
			[FieldOffset(Offset = "0x20")]
			private RL05ReportCastView m_prefab;

			// Token: 0x0402B98E RID: 178574
			[Token(Token = "0x402B98E")]
			[FieldOffset(Offset = "0x28")]
			private float m_cachedHeight;

			// Token: 0x0402B990 RID: 178576
			[Token(Token = "0x402B990")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_castNames;

			// Token: 0x0402B991 RID: 178577
			[Token(Token = "0x402B991")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_castNames;

			// Token: 0x0402B992 RID: 178578
			[Token(Token = "0x402B992")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetNamesWithList;

			// Token: 0x0402B993 RID: 178579
			[Token(Token = "0x402B993")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B994 RID: 178580
			[Token(Token = "0x402B994")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402B995 RID: 178581
			[Token(Token = "0x402B995")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402B996 RID: 178582
			[Token(Token = "0x402B996")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnRenderView;
		}
	}
}
