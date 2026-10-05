using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E1D RID: 15901
	[Token(Token = "0x2003E1D")]
	public class SquadFriendTabGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B9E RID: 101278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B9E")]
		[Address(RVA = "0x113D000", Offset = "0x113BC00", VA = "0x18113D000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B9F")]
		[Address(RVA = "0x113CB50", Offset = "0x113B750", VA = "0x18113CB50")]
		public void ApplyData(List<ProfessionCategory> professionList, ProfessionCategory selectedProfession, Action<ProfessionCategory> clickAction)
		{
		}

		// Token: 0x06018BA0 RID: 101280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA0")]
		[Address(RVA = "0x113CEB0", Offset = "0x113BAB0", VA = "0x18113CEB0")]
		public void UpdateSelectedItem(ProfessionCategory professionCategory)
		{
		}

		// Token: 0x06018BA1 RID: 101281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA1")]
		[Address(RVA = "0x113D110", Offset = "0x113BD10", VA = "0x18113D110")]
		public SquadFriendTabGroupView()
		{
		}

		// Token: 0x0401E5E5 RID: 124389
		[Token(Token = "0x401E5E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0401E5E6 RID: 124390
		[Token(Token = "0x401E5E6")]
		[FieldOffset(Offset = "0x20")]
		private bool m_inited;

		// Token: 0x0401E5E7 RID: 124391
		[Token(Token = "0x401E5E7")]
		[FieldOffset(Offset = "0x28")]
		private SquadFriendTabGroupView.Adapter m_adapter;

		// Token: 0x0401E5E8 RID: 124392
		[Token(Token = "0x401E5E8")]
		[FieldOffset(Offset = "0x30")]
		private List<ProfessionCategory> m_professionList;

		// Token: 0x0401E5E9 RID: 124393
		[Token(Token = "0x401E5E9")]
		[FieldOffset(Offset = "0x38")]
		private List<SquadFriendProfessionTabView.Param> m_paramList;

		// Token: 0x0401E5EA RID: 124394
		[Token(Token = "0x401E5EA")]
		[FieldOffset(Offset = "0x40")]
		private int m_selectedIndex;

		// Token: 0x0401E5EB RID: 124395
		[Token(Token = "0x401E5EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E5EC RID: 124396
		[Token(Token = "0x401E5EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0401E5ED RID: 124397
		[Token(Token = "0x401E5ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelectedItem;

		// Token: 0x0401E5EE RID: 124398
		[Token(Token = "0x401E5EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E1E RID: 15902
		[Token(Token = "0x2003E1E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003AEA RID: 15082
			// (get) Token: 0x06018BA2 RID: 101282 RVA: 0x0009B820 File Offset: 0x00099A20
			[Token(Token = "0x17003AEA")]
			public override int count
			{
				[Token(Token = "0x6018BA2")]
				[Address(RVA = "0x1135370", Offset = "0x1133F70", VA = "0x181135370", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018BA3 RID: 101283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018BA3")]
			[Address(RVA = "0x1135090", Offset = "0x1133C90", VA = "0x181135090", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018BA4 RID: 101284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BA4")]
			[Address(RVA = "0x1135310", Offset = "0x1133F10", VA = "0x181135310")]
			public Adapter()
			{
			}

			// Token: 0x0401E5EF RID: 124399
			[Token(Token = "0x401E5EF")]
			[FieldOffset(Offset = "0x20")]
			public List<SquadFriendProfessionTabView.Param> paramList;

			// Token: 0x0401E5F0 RID: 124400
			[Token(Token = "0x401E5F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E5F1 RID: 124401
			[Token(Token = "0x401E5F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401E5F2 RID: 124402
			[Token(Token = "0x401E5F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
