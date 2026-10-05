using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C12 RID: 23570
	[Token(Token = "0x2005C12")]
	public class CommonCharSelectAdapter : LoopScrollAdapter<CommonCharSelectAdapter.ViewHolder, TemplateCharSelectCardViewModel>
	{
		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x060222C3 RID: 139971 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060222C4 RID: 139972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700501F")]
		public string actId
		{
			[Token(Token = "0x60222C3")]
			[Address(RVA = "0x1CA9660", Offset = "0x1CA8260", VA = "0x181CA9660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60222C4")]
			[Address(RVA = "0x1CA9780", Offset = "0x1CA8380", VA = "0x181CA9780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x060222C5 RID: 139973 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060222C6 RID: 139974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005020")]
		public string pageName
		{
			[Token(Token = "0x60222C5")]
			[Address(RVA = "0x1CA9720", Offset = "0x1CA8320", VA = "0x181CA9720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60222C6")]
			[Address(RVA = "0x1CA9880", Offset = "0x1CA8480", VA = "0x181CA9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x060222C7 RID: 139975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060222C8 RID: 139976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005021")]
		public TemplateCharSelectCardView charCardPrefab
		{
			[Token(Token = "0x60222C7")]
			[Address(RVA = "0x1CA96C0", Offset = "0x1CA82C0", VA = "0x181CA96C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60222C8")]
			[Address(RVA = "0x1CA9800", Offset = "0x1CA8400", VA = "0x181CA9800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060222C9 RID: 139977 RVA: 0x000BC880 File Offset: 0x000BAA80
		[Token(Token = "0x60222C9")]
		[Address(RVA = "0x1CA94D0", Offset = "0x1CA80D0", VA = "0x181CA94D0")]
		private int _GetInstIndex(int instId)
		{
			return 0;
		}

		// Token: 0x060222CA RID: 139978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60222CA")]
		[Address(RVA = "0x1CA8D90", Offset = "0x1CA7990", VA = "0x181CA8D90", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060222CB RID: 139979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222CB")]
		[Address(RVA = "0x1CA8E50", Offset = "0x1CA7A50", VA = "0x181CA8E50", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CommonCharSelectAdapter.ViewHolder holder, TemplateCharSelectCardViewModel data)
		{
		}

		// Token: 0x060222CC RID: 139980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222CC")]
		[Address(RVA = "0x1CA9460", Offset = "0x1CA8060", VA = "0x181CA9460")]
		private void Update()
		{
		}

		// Token: 0x060222CD RID: 139981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222CD")]
		[Address(RVA = "0x1CA95E0", Offset = "0x1CA81E0", VA = "0x181CA95E0")]
		public CommonCharSelectAdapter()
		{
		}

		// Token: 0x0402EDD5 RID: 191957
		[Token(Token = "0x402EDD5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonCharSelectCharHolder _holderPrefab;

		// Token: 0x0402EDD6 RID: 191958
		[Token(Token = "0x402EDD6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIIntEvent _charClick;

		// Token: 0x0402EDD7 RID: 191959
		[Token(Token = "0x402EDD7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private uint _asyncCostPerFrame;

		// Token: 0x0402EDD8 RID: 191960
		[Token(Token = "0x402EDD8")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public List<int> selectInstIdList;

		// Token: 0x0402EDD9 RID: 191961
		[Token(Token = "0x402EDD9")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public bool isSingle;

		// Token: 0x0402EDDD RID: 191965
		[Token(Token = "0x402EDDD")]
		[FieldOffset(Offset = "0x98")]
		private AsyncGameObjectLoader m_viewLoader;

		// Token: 0x0402EDDE RID: 191966
		[Token(Token = "0x402EDDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0402EDDF RID: 191967
		[Token(Token = "0x402EDDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0402EDE0 RID: 191968
		[Token(Token = "0x402EDE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0402EDE1 RID: 191969
		[Token(Token = "0x402EDE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_pageName;

		// Token: 0x0402EDE2 RID: 191970
		[Token(Token = "0x402EDE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_charCardPrefab;

		// Token: 0x0402EDE3 RID: 191971
		[Token(Token = "0x402EDE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_charCardPrefab;

		// Token: 0x0402EDE4 RID: 191972
		[Token(Token = "0x402EDE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetInstIndex;

		// Token: 0x0402EDE5 RID: 191973
		[Token(Token = "0x402EDE5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402EDE6 RID: 191974
		[Token(Token = "0x402EDE6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402EDE7 RID: 191975
		[Token(Token = "0x402EDE7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402EDE8 RID: 191976
		[Token(Token = "0x402EDE8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C13 RID: 23571
		[Token(Token = "0x2005C13")]
		public class ViewHolder
		{
			// Token: 0x060222CE RID: 139982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60222CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402EDE9 RID: 191977
			[Token(Token = "0x402EDE9")]
			[FieldOffset(Offset = "0x10")]
			public CommonCharSelectCharHolder holder;
		}
	}
}
