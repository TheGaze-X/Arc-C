using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6C RID: 27500
	[Token(Token = "0x2006B6C")]
	public class ArchiveDisasterTypeItemAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x060274AD RID: 160941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060274AE RID: 160942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD7")]
		public ArchiveDisasterController controller
		{
			[Token(Token = "0x60274AD")]
			[Address(RVA = "0x227C3E0", Offset = "0x227AFE0", VA = "0x18227C3E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60274AE")]
			[Address(RVA = "0x227C630", Offset = "0x227B230", VA = "0x18227C630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x060274AF RID: 160943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060274B0 RID: 160944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD8")]
		public List<DisasterTypeModel> dataSource
		{
			[Token(Token = "0x60274AF")]
			[Address(RVA = "0x227C440", Offset = "0x227B040", VA = "0x18227C440")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60274B0")]
			[Address(RVA = "0x227C6B0", Offset = "0x227B2B0", VA = "0x18227C6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x060274B1 RID: 160945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060274B2 RID: 160946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD9")]
		public string selectTypeId
		{
			[Token(Token = "0x60274B1")]
			[Address(RVA = "0x227C4A0", Offset = "0x227B0A0", VA = "0x18227C4A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60274B2")]
			[Address(RVA = "0x227C730", Offset = "0x227B330", VA = "0x18227C730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x060274B3 RID: 160947 RVA: 0x000CDF68 File Offset: 0x000CC168
		// (set) Token: 0x060274B4 RID: 160948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CDA")]
		public bool showSwitchAnim
		{
			[Token(Token = "0x60274B3")]
			[Address(RVA = "0x227C500", Offset = "0x227B100", VA = "0x18227C500")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60274B4")]
			[Address(RVA = "0x227C7B0", Offset = "0x227B3B0", VA = "0x18227C7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x060274B5 RID: 160949 RVA: 0x000CDF80 File Offset: 0x000CC180
		[Token(Token = "0x17005CDB")]
		public override int totalCount
		{
			[Token(Token = "0x60274B5")]
			[Address(RVA = "0x227C560", Offset = "0x227B160", VA = "0x18227C560", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060274B6 RID: 160950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274B6")]
		[Address(RVA = "0x227BF70", Offset = "0x227AB70", VA = "0x18227BF70", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x060274B7 RID: 160951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60274B7")]
		[Address(RVA = "0x227C260", Offset = "0x227AE60", VA = "0x18227C260", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060274B8 RID: 160952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274B8")]
		[Address(RVA = "0x227C380", Offset = "0x227AF80", VA = "0x18227C380")]
		public ArchiveDisasterTypeItemAdapter()
		{
		}

		// Token: 0x04037A24 RID: 227876
		[Token(Token = "0x4037A24")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04037A29 RID: 227881
		[Token(Token = "0x4037A29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037A2A RID: 227882
		[Token(Token = "0x4037A2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037A2B RID: 227883
		[Token(Token = "0x4037A2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x04037A2C RID: 227884
		[Token(Token = "0x4037A2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x04037A2D RID: 227885
		[Token(Token = "0x4037A2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectTypeId;

		// Token: 0x04037A2E RID: 227886
		[Token(Token = "0x4037A2E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectTypeId;

		// Token: 0x04037A2F RID: 227887
		[Token(Token = "0x4037A2F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showSwitchAnim;

		// Token: 0x04037A30 RID: 227888
		[Token(Token = "0x4037A30")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_showSwitchAnim;

		// Token: 0x04037A31 RID: 227889
		[Token(Token = "0x4037A31")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04037A32 RID: 227890
		[Token(Token = "0x4037A32")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04037A33 RID: 227891
		[Token(Token = "0x4037A33")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04037A34 RID: 227892
		[Token(Token = "0x4037A34")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
