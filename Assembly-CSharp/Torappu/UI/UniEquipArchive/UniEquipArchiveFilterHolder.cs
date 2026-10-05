using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BCC RID: 15308
	[Token(Token = "0x2003BCC")]
	public class UniEquipArchiveFilterHolder : UICharacterFilterHolder
	{
		// Token: 0x06017F6F RID: 98159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F6F")]
		[Address(RVA = "0x1064550", Offset = "0x1063150", VA = "0x181064550")]
		protected void OnCreate()
		{
		}

		// Token: 0x06017F70 RID: 98160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F70")]
		[Address(RVA = "0x10643D0", Offset = "0x1062FD0", VA = "0x1810643D0")]
		public void ApplyTrackNum(int trackNum)
		{
		}

		// Token: 0x06017F71 RID: 98161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F71")]
		[Address(RVA = "0x1064750", Offset = "0x1063350", VA = "0x181064750")]
		private void _ApplyData()
		{
		}

		// Token: 0x06017F72 RID: 98162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F72")]
		[Address(RVA = "0x10648B0", Offset = "0x10634B0", VA = "0x1810648B0")]
		private void _OnShowTrackClick(bool showTrack)
		{
		}

		// Token: 0x06017F73 RID: 98163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F73")]
		[Address(RVA = "0x1064980", Offset = "0x1063580", VA = "0x181064980")]
		private void _OnUnlockTabClick(UniEquipArchiveFilterEquipState filterState)
		{
		}

		// Token: 0x06017F74 RID: 98164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F74")]
		[Address(RVA = "0x1064A50", Offset = "0x1063650", VA = "0x181064A50")]
		public UniEquipArchiveFilterHolder()
		{
		}

		// Token: 0x0401D010 RID: 118800
		[Token(Token = "0x401D010")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipArchiveFilterView _filterView;

		// Token: 0x0401D011 RID: 118801
		[Token(Token = "0x401D011")]
		[FieldOffset(Offset = "0x30")]
		private UniEquipArchiveFilterProperty m_prop;

		// Token: 0x0401D012 RID: 118802
		[Token(Token = "0x401D012")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401D013 RID: 118803
		[Token(Token = "0x401D013")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyTrackNum;

		// Token: 0x0401D014 RID: 118804
		[Token(Token = "0x401D014")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0401D015 RID: 118805
		[Token(Token = "0x401D015")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnShowTrackClick;

		// Token: 0x0401D016 RID: 118806
		[Token(Token = "0x401D016")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnlockTabClick;

		// Token: 0x0401D017 RID: 118807
		[Token(Token = "0x401D017")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BCD RID: 15309
		[Token(Token = "0x2003BCD")]
		public class FilterParam : IHotfixable
		{
			// Token: 0x06017F75 RID: 98165 RVA: 0x00098C70 File Offset: 0x00096E70
			[Token(Token = "0x6017F75")]
			[Address(RVA = "0x105EEB0", Offset = "0x105DAB0", VA = "0x18105EEB0")]
			public bool IsIncludeByTrackFilter(bool haveTrack)
			{
				return default(bool);
			}

			// Token: 0x06017F76 RID: 98166 RVA: 0x00098C88 File Offset: 0x00096E88
			[Token(Token = "0x6017F76")]
			[Address(RVA = "0x105EE10", Offset = "0x105DA10", VA = "0x18105EE10")]
			public bool IsIncludByEquipFilter(bool isEquipUnlocked)
			{
				return default(bool);
			}

			// Token: 0x06017F77 RID: 98167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F77")]
			[Address(RVA = "0x105EFE0", Offset = "0x105DBE0", VA = "0x18105EFE0")]
			public FilterParam()
			{
			}

			// Token: 0x0401D018 RID: 118808
			[Token(Token = "0x401D018")]
			[FieldOffset(Offset = "0x10")]
			public bool showTrack;

			// Token: 0x0401D019 RID: 118809
			[Token(Token = "0x401D019")]
			[FieldOffset(Offset = "0x14")]
			public UniEquipArchiveFilterEquipState equipState;

			// Token: 0x0401D01A RID: 118810
			[Token(Token = "0x401D01A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsIncludeByTrackFilter;

			// Token: 0x0401D01B RID: 118811
			[Token(Token = "0x401D01B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsIncludByEquipFilter;

			// Token: 0x0401D01C RID: 118812
			[Token(Token = "0x401D01C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003BCE RID: 15310
		[Token(Token = "0x2003BCE")]
		public struct Builder
		{
			// Token: 0x06017F78 RID: 98168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F78")]
			[Address(RVA = "0x105E350", Offset = "0x105CF50", VA = "0x18105E350")]
			public UniEquipArchiveFilterHolder Build()
			{
				return null;
			}

			// Token: 0x0401D01D RID: 118813
			[Token(Token = "0x401D01D")]
			[FieldOffset(Offset = "0x0")]
			public UniEquipArchiveFilterHolder prefab;

			// Token: 0x0401D01E RID: 118814
			[Token(Token = "0x401D01E")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform container;

			// Token: 0x0401D01F RID: 118815
			[Token(Token = "0x401D01F")]
			[FieldOffset(Offset = "0x10")]
			public ILoadAsset assetLoader;

			// Token: 0x0401D020 RID: 118816
			[Token(Token = "0x401D020")]
			[FieldOffset(Offset = "0x18")]
			public UICharacterFilterHolder.IFilterHandler filterHandler;
		}
	}
}
