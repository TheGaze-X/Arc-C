using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FB8 RID: 28600
	[Token(Token = "0x2006FB8")]
	public abstract class ActMultiV3SquadColView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060289C4 RID: 166340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289C4")]
		[Address(RVA = "0x23EEE30", Offset = "0x23EDA30", VA = "0x1823EEE30")]
		public void Render(ActMultiV3IdentityType identityType, List<ActMultiV3CharViewModel> charList)
		{
		}

		// Token: 0x060289C5 RID: 166341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289C5")]
		[Address(RVA = "0x23EE910", Offset = "0x23ED510", VA = "0x1823EE910", Slot = "4")]
		protected virtual void OnRenderView()
		{
		}

		// Token: 0x060289C6 RID: 166342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289C6")]
		[Address(RVA = "0x23EEFD0", Offset = "0x23EDBD0", VA = "0x1823EEFD0")]
		protected ActMultiV3SquadColView()
		{
		}

		// Token: 0x04039DA3 RID: 236963
		[Token(Token = "0x4039DA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x04039DA4 RID: 236964
		[Token(Token = "0x4039DA4")]
		[FieldOffset(Offset = "0x20")]
		protected ActMultiV3IdentityType m_identityType;

		// Token: 0x04039DA5 RID: 236965
		[Token(Token = "0x4039DA5")]
		[FieldOffset(Offset = "0x28")]
		protected List<ActMultiV3CharViewModel> m_charList;

		// Token: 0x04039DA6 RID: 236966
		[Token(Token = "0x4039DA6")]
		[FieldOffset(Offset = "0x30")]
		private ActMultiV3SquadColView.CharListAdapter m_charListAdapter;

		// Token: 0x04039DA7 RID: 236967
		[Token(Token = "0x4039DA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039DA8 RID: 236968
		[Token(Token = "0x4039DA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderView;

		// Token: 0x04039DA9 RID: 236969
		[Token(Token = "0x4039DA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FB9 RID: 28601
		[Token(Token = "0x2006FB9")]
		private class CharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060289C7 RID: 166343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60289C7")]
			[Address(RVA = "0x24028C0", Offset = "0x24014C0", VA = "0x1824028C0")]
			public CharListAdapter(ActMultiV3SquadColView closure)
			{
			}

			// Token: 0x17005FD4 RID: 24532
			// (get) Token: 0x060289C8 RID: 166344 RVA: 0x000D2648 File Offset: 0x000D0848
			[Token(Token = "0x17005FD4")]
			public override int count
			{
				[Token(Token = "0x60289C8")]
				[Address(RVA = "0x24029C0", Offset = "0x24015C0", VA = "0x1824029C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060289C9 RID: 166345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60289C9")]
			[Address(RVA = "0x2402200", Offset = "0x2400E00", VA = "0x182402200", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039DAA RID: 236970
			[Token(Token = "0x4039DAA")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3SquadColView m_closure;

			// Token: 0x04039DAB RID: 236971
			[Token(Token = "0x4039DAB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039DAC RID: 236972
			[Token(Token = "0x4039DAC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039DAD RID: 236973
			[Token(Token = "0x4039DAD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
