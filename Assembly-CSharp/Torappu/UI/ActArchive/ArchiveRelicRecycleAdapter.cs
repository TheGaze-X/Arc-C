using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C13 RID: 27667
	[Token(Token = "0x2006C13")]
	public class ArchiveRelicRecycleAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x06027809 RID: 161801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602780A RID: 161802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D39")]
		public ArchiveRelicController controller
		{
			[Token(Token = "0x6027809")]
			[Address(RVA = "0x22B31D0", Offset = "0x22B1DD0", VA = "0x1822B31D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602780A")]
			[Address(RVA = "0x22B3420", Offset = "0x22B2020", VA = "0x1822B3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x0602780B RID: 161803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602780C RID: 161804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D3A")]
		public List<ArchiveRelicItemGroupModel> groupModel
		{
			[Token(Token = "0x602780B")]
			[Address(RVA = "0x22B3230", Offset = "0x22B1E30", VA = "0x1822B3230")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602780C")]
			[Address(RVA = "0x22B34A0", Offset = "0x22B20A0", VA = "0x1822B34A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x0602780D RID: 161805 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602780E RID: 161806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D3B")]
		public string selectItemId
		{
			[Token(Token = "0x602780D")]
			[Address(RVA = "0x22B3290", Offset = "0x22B1E90", VA = "0x1822B3290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602780E")]
			[Address(RVA = "0x22B3520", Offset = "0x22B2120", VA = "0x1822B3520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x0602780F RID: 161807 RVA: 0x000CE940 File Offset: 0x000CCB40
		// (set) Token: 0x06027810 RID: 161808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D3C")]
		public bool showSwitchAnim
		{
			[Token(Token = "0x602780F")]
			[Address(RVA = "0x22B32F0", Offset = "0x22B1EF0", VA = "0x1822B32F0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6027810")]
			[Address(RVA = "0x22B35A0", Offset = "0x22B21A0", VA = "0x1822B35A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x06027811 RID: 161809 RVA: 0x000CE958 File Offset: 0x000CCB58
		[Token(Token = "0x17005D3D")]
		public override int totalCount
		{
			[Token(Token = "0x6027811")]
			[Address(RVA = "0x22B3350", Offset = "0x22B1F50", VA = "0x1822B3350", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027812 RID: 161810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027812")]
		[Address(RVA = "0x22B2D70", Offset = "0x22B1970", VA = "0x1822B2D70", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06027813 RID: 161811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027813")]
		[Address(RVA = "0x22B3050", Offset = "0x22B1C50", VA = "0x1822B3050", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027814 RID: 161812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027814")]
		[Address(RVA = "0x22B3170", Offset = "0x22B1D70", VA = "0x1822B3170")]
		public ArchiveRelicRecycleAdapter()
		{
		}

		// Token: 0x0403800F RID: 229391
		[Token(Token = "0x403800F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _groupPrefab;

		// Token: 0x04038010 RID: 229392
		[Token(Token = "0x4038010")]
		[FieldOffset(Offset = "0x60")]
		private int m_totalCount;

		// Token: 0x04038015 RID: 229397
		[Token(Token = "0x4038015")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038016 RID: 229398
		[Token(Token = "0x4038016")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038017 RID: 229399
		[Token(Token = "0x4038017")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupModel;

		// Token: 0x04038018 RID: 229400
		[Token(Token = "0x4038018")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_groupModel;

		// Token: 0x04038019 RID: 229401
		[Token(Token = "0x4038019")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectItemId;

		// Token: 0x0403801A RID: 229402
		[Token(Token = "0x403801A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectItemId;

		// Token: 0x0403801B RID: 229403
		[Token(Token = "0x403801B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showSwitchAnim;

		// Token: 0x0403801C RID: 229404
		[Token(Token = "0x403801C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_showSwitchAnim;

		// Token: 0x0403801D RID: 229405
		[Token(Token = "0x403801D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0403801E RID: 229406
		[Token(Token = "0x403801E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403801F RID: 229407
		[Token(Token = "0x403801F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04038020 RID: 229408
		[Token(Token = "0x4038020")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
