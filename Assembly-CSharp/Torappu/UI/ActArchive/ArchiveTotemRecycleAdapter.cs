using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C51 RID: 27729
	[Token(Token = "0x2006C51")]
	public class ArchiveTotemRecycleAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x06027944 RID: 162116 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027945 RID: 162117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D83")]
		public ArchiveTotemController controller
		{
			[Token(Token = "0x6027944")]
			[Address(RVA = "0x22C4F60", Offset = "0x22C3B60", VA = "0x1822C4F60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027945")]
			[Address(RVA = "0x22C51B0", Offset = "0x22C3DB0", VA = "0x1822C51B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x06027946 RID: 162118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027947 RID: 162119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D84")]
		public List<ArchiveTotemGroupModel> groupSource
		{
			[Token(Token = "0x6027946")]
			[Address(RVA = "0x22C4FC0", Offset = "0x22C3BC0", VA = "0x1822C4FC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027947")]
			[Address(RVA = "0x22C5230", Offset = "0x22C3E30", VA = "0x1822C5230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x06027948 RID: 162120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027949 RID: 162121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D85")]
		public string selectItemId
		{
			[Token(Token = "0x6027948")]
			[Address(RVA = "0x22C5020", Offset = "0x22C3C20", VA = "0x1822C5020")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027949")]
			[Address(RVA = "0x22C52B0", Offset = "0x22C3EB0", VA = "0x1822C52B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x0602794A RID: 162122 RVA: 0x000CEC58 File Offset: 0x000CCE58
		// (set) Token: 0x0602794B RID: 162123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D86")]
		public bool showSwitchAnim
		{
			[Token(Token = "0x602794A")]
			[Address(RVA = "0x22C5080", Offset = "0x22C3C80", VA = "0x1822C5080")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x602794B")]
			[Address(RVA = "0x22C5330", Offset = "0x22C3F30", VA = "0x1822C5330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x0602794C RID: 162124 RVA: 0x000CEC70 File Offset: 0x000CCE70
		[Token(Token = "0x17005D87")]
		public override int totalCount
		{
			[Token(Token = "0x602794C")]
			[Address(RVA = "0x22C50E0", Offset = "0x22C3CE0", VA = "0x1822C50E0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602794D RID: 162125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602794D")]
		[Address(RVA = "0x22C4B10", Offset = "0x22C3710", VA = "0x1822C4B10", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x0602794E RID: 162126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602794E")]
		[Address(RVA = "0x22C4DE0", Offset = "0x22C39E0", VA = "0x1822C4DE0", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602794F RID: 162127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602794F")]
		[Address(RVA = "0x22C4F00", Offset = "0x22C3B00", VA = "0x1822C4F00")]
		public ArchiveTotemRecycleAdapter()
		{
		}

		// Token: 0x04038214 RID: 229908
		[Token(Token = "0x4038214")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x04038219 RID: 229913
		[Token(Token = "0x4038219")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403821A RID: 229914
		[Token(Token = "0x403821A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403821B RID: 229915
		[Token(Token = "0x403821B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupSource;

		// Token: 0x0403821C RID: 229916
		[Token(Token = "0x403821C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_groupSource;

		// Token: 0x0403821D RID: 229917
		[Token(Token = "0x403821D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectItemId;

		// Token: 0x0403821E RID: 229918
		[Token(Token = "0x403821E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectItemId;

		// Token: 0x0403821F RID: 229919
		[Token(Token = "0x403821F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showSwitchAnim;

		// Token: 0x04038220 RID: 229920
		[Token(Token = "0x4038220")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_showSwitchAnim;

		// Token: 0x04038221 RID: 229921
		[Token(Token = "0x4038221")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04038222 RID: 229922
		[Token(Token = "0x4038222")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04038223 RID: 229923
		[Token(Token = "0x4038223")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04038224 RID: 229924
		[Token(Token = "0x4038224")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
