using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F34 RID: 20276
	[Token(Token = "0x2004F34")]
	public class EnemyHandBookScrollListAdapter : RecycleLoopScrollAdapter<EnemyHandBookScrollListItemHolder, EnemyHandBookEverViewModel>
	{
		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x0601E32E RID: 123694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E32F RID: 123695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046CB")]
		public string selectedId
		{
			[Token(Token = "0x601E32E")]
			[Address(RVA = "0x17EA0E0", Offset = "0x17E8CE0", VA = "0x1817EA0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E32F")]
			[Address(RVA = "0x17EA230", Offset = "0x17E8E30", VA = "0x1817EA230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x0601E330 RID: 123696 RVA: 0x000ADCD0 File Offset: 0x000ABED0
		// (set) Token: 0x0601E331 RID: 123697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046CC")]
		public bool disableNewFlag
		{
			[Token(Token = "0x601E330")]
			[Address(RVA = "0x17EA020", Offset = "0x17E8C20", VA = "0x1817EA020")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x601E331")]
			[Address(RVA = "0x17EA140", Offset = "0x17E8D40", VA = "0x1817EA140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x0601E332 RID: 123698 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E333 RID: 123699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046CD")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x601E332")]
			[Address(RVA = "0x17EA080", Offset = "0x17E8C80", VA = "0x1817EA080")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E333")]
			[Address(RVA = "0x17EA1B0", Offset = "0x17E8DB0", VA = "0x1817EA1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E334 RID: 123700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E334")]
		[Address(RVA = "0x17E9BD0", Offset = "0x17E87D0", VA = "0x1817E9BD0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, EnemyHandBookScrollListItemHolder holder, EnemyHandBookEverViewModel data)
		{
		}

		// Token: 0x0601E335 RID: 123701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E335")]
		[Address(RVA = "0x17E9F00", Offset = "0x17E8B00", VA = "0x1817E9F00", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601E336 RID: 123702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E336")]
		[Address(RVA = "0x17E9FB0", Offset = "0x17E8BB0", VA = "0x1817E9FB0")]
		public EnemyHandBookScrollListAdapter()
		{
		}

		// Token: 0x040283E2 RID: 164834
		[Token(Token = "0x40283E2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x040283E6 RID: 164838
		[Token(Token = "0x40283E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedId;

		// Token: 0x040283E7 RID: 164839
		[Token(Token = "0x40283E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedId;

		// Token: 0x040283E8 RID: 164840
		[Token(Token = "0x40283E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_disableNewFlag;

		// Token: 0x040283E9 RID: 164841
		[Token(Token = "0x40283E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_disableNewFlag;

		// Token: 0x040283EA RID: 164842
		[Token(Token = "0x40283EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x040283EB RID: 164843
		[Token(Token = "0x40283EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040283EC RID: 164844
		[Token(Token = "0x40283EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040283ED RID: 164845
		[Token(Token = "0x40283ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040283EE RID: 164846
		[Token(Token = "0x40283EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
