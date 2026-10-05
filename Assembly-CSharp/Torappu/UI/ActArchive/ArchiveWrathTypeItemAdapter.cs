using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C69 RID: 27753
	[Token(Token = "0x2006C69")]
	public class ArchiveWrathTypeItemAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x060279BF RID: 162239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060279C0 RID: 162240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D98")]
		public List<WrathTypeModel> dataSource
		{
			[Token(Token = "0x60279BF")]
			[Address(RVA = "0x22CAF00", Offset = "0x22C9B00", VA = "0x1822CAF00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60279C0")]
			[Address(RVA = "0x22CB0A0", Offset = "0x22C9CA0", VA = "0x1822CB0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x060279C1 RID: 162241 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060279C2 RID: 162242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D99")]
		public ArchiveWrathController controller
		{
			[Token(Token = "0x60279C1")]
			[Address(RVA = "0x22CAEA0", Offset = "0x22C9AA0", VA = "0x1822CAEA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60279C2")]
			[Address(RVA = "0x22CB020", Offset = "0x22C9C20", VA = "0x1822CB020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x060279C3 RID: 162243 RVA: 0x000CEDD8 File Offset: 0x000CCFD8
		[Token(Token = "0x17005D9A")]
		public override int totalCount
		{
			[Token(Token = "0x60279C3")]
			[Address(RVA = "0x22CAF60", Offset = "0x22C9B60", VA = "0x1822CAF60", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060279C4 RID: 162244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279C4")]
		[Address(RVA = "0x22CAAF0", Offset = "0x22C96F0", VA = "0x1822CAAF0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x060279C5 RID: 162245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279C5")]
		[Address(RVA = "0x22CAD20", Offset = "0x22C9920", VA = "0x1822CAD20", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060279C6 RID: 162246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279C6")]
		[Address(RVA = "0x22CAE40", Offset = "0x22C9A40", VA = "0x1822CAE40")]
		public ArchiveWrathTypeItemAdapter()
		{
		}

		// Token: 0x040382E8 RID: 230120
		[Token(Token = "0x40382E8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x040382EB RID: 230123
		[Token(Token = "0x40382EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x040382EC RID: 230124
		[Token(Token = "0x40382EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x040382ED RID: 230125
		[Token(Token = "0x40382ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040382EE RID: 230126
		[Token(Token = "0x40382EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040382EF RID: 230127
		[Token(Token = "0x40382EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x040382F0 RID: 230128
		[Token(Token = "0x40382F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040382F1 RID: 230129
		[Token(Token = "0x40382F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040382F2 RID: 230130
		[Token(Token = "0x40382F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
