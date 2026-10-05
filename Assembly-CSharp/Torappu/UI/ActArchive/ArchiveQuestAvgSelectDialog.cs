using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE7 RID: 27623
	[Token(Token = "0x2006BE7")]
	public class ArchiveQuestAvgSelectDialog : UICustomDialog<ArchiveQuestAvgSelectDialog.Options>
	{
		// Token: 0x06027723 RID: 161571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027723")]
		[Address(RVA = "0x229BE30", Offset = "0x229AA30", VA = "0x18229BE30", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06027724 RID: 161572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027724")]
		[Address(RVA = "0x229BF00", Offset = "0x229AB00", VA = "0x18229BF00", Slot = "7")]
		protected override void OnRender(ArchiveQuestAvgSelectDialog.Options input)
		{
		}

		// Token: 0x06027725 RID: 161573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027725")]
		[Address(RVA = "0x229C1C0", Offset = "0x229ADC0", VA = "0x18229C1C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027726 RID: 161574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027726")]
		[Address(RVA = "0x229BD40", Offset = "0x229A940", VA = "0x18229BD40")]
		public void EventOnClickStartIndex(int index)
		{
		}

		// Token: 0x06027727 RID: 161575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027727")]
		[Address(RVA = "0x229BE90", Offset = "0x229AA90", VA = "0x18229BE90")]
		public void OnBackClick()
		{
		}

		// Token: 0x06027728 RID: 161576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027728")]
		[Address(RVA = "0x229C2E0", Offset = "0x229AEE0", VA = "0x18229C2E0")]
		private void _OnSelect()
		{
		}

		// Token: 0x06027729 RID: 161577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027729")]
		[Address(RVA = "0x229C360", Offset = "0x229AF60", VA = "0x18229C360")]
		public ArchiveQuestAvgSelectDialog()
		{
		}

		// Token: 0x04037E32 RID: 228914
		[Token(Token = "0x4037E32")]
		[NonSerialized]
		public const int NOT_SELECT_COUNT = -1;

		// Token: 0x04037E33 RID: 228915
		[Token(Token = "0x4037E33")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04037E34 RID: 228916
		[Token(Token = "0x4037E34")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x04037E35 RID: 228917
		[Token(Token = "0x4037E35")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textQuestType;

		// Token: 0x04037E36 RID: 228918
		[Token(Token = "0x4037E36")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textQuestName;

		// Token: 0x04037E37 RID: 228919
		[Token(Token = "0x4037E37")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textAvgName1;

		// Token: 0x04037E38 RID: 228920
		[Token(Token = "0x4037E38")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textAvgName2;

		// Token: 0x04037E39 RID: 228921
		[Token(Token = "0x4037E39")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateToggle _toggleIcon1;

		// Token: 0x04037E3A RID: 228922
		[Token(Token = "0x4037E3A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _toggleIcon2;

		// Token: 0x04037E3B RID: 228923
		[Token(Token = "0x4037E3B")]
		[FieldOffset(Offset = "0x80")]
		private Action<int> m_onSelect;

		// Token: 0x04037E3C RID: 228924
		[Token(Token = "0x4037E3C")]
		[FieldOffset(Offset = "0x88")]
		private int m_index;

		// Token: 0x04037E3D RID: 228925
		[Token(Token = "0x4037E3D")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_hasInited;

		// Token: 0x04037E3E RID: 228926
		[Token(Token = "0x4037E3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04037E3F RID: 228927
		[Token(Token = "0x4037E3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04037E40 RID: 228928
		[Token(Token = "0x4037E40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037E41 RID: 228929
		[Token(Token = "0x4037E41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickStartIndex;

		// Token: 0x04037E42 RID: 228930
		[Token(Token = "0x4037E42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04037E43 RID: 228931
		[Token(Token = "0x4037E43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSelect;

		// Token: 0x04037E44 RID: 228932
		[Token(Token = "0x4037E44")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BE8 RID: 27624
		[Token(Token = "0x2006BE8")]
		public class Options
		{
			// Token: 0x0602772A RID: 161578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602772A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04037E45 RID: 228933
			[Token(Token = "0x4037E45")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2ArchiveQuestType questType;

			// Token: 0x04037E46 RID: 228934
			[Token(Token = "0x4037E46")]
			[FieldOffset(Offset = "0x18")]
			public string questTypeName;

			// Token: 0x04037E47 RID: 228935
			[Token(Token = "0x4037E47")]
			[FieldOffset(Offset = "0x20")]
			public string questName;

			// Token: 0x04037E48 RID: 228936
			[Token(Token = "0x4037E48")]
			[FieldOffset(Offset = "0x28")]
			public List<SandboxV2ArchiveQuestAvgData> avgNames;

			// Token: 0x04037E49 RID: 228937
			[Token(Token = "0x4037E49")]
			[FieldOffset(Offset = "0x30")]
			public Action<int> onSelect;
		}
	}
}
