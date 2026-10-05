using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FC0 RID: 16320
	[Token(Token = "0x2003FC0")]
	public class SiracusaChatNarrationComp : SiracusaChatSwitchableComp
	{
		// Token: 0x060194D6 RID: 103638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194D6")]
		[Address(RVA = "0x1208AE0", Offset = "0x12076E0", VA = "0x181208AE0")]
		private void _Render(string content)
		{
		}

		// Token: 0x060194D7 RID: 103639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194D7")]
		[Address(RVA = "0x1208B80", Offset = "0x1207780", VA = "0x181208B80")]
		public SiracusaChatNarrationComp()
		{
		}

		// Token: 0x0401F6E9 RID: 128745
		[Token(Token = "0x401F6E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0401F6EA RID: 128746
		[Token(Token = "0x401F6EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _contentText;

		// Token: 0x0401F6EB RID: 128747
		[Token(Token = "0x401F6EB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401F6EC RID: 128748
		[Token(Token = "0x401F6EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401F6ED RID: 128749
		[Token(Token = "0x401F6ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FC1 RID: 16321
		[Token(Token = "0x2003FC1")]
		public class ViewModel
		{
			// Token: 0x060194D8 RID: 103640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194D8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0401F6EE RID: 128750
			[Token(Token = "0x401F6EE")]
			[FieldOffset(Offset = "0x10")]
			public SiracusaChatNarrationComp prefab;

			// Token: 0x0401F6EF RID: 128751
			[Token(Token = "0x401F6EF")]
			[FieldOffset(Offset = "0x18")]
			public string content;
		}

		// Token: 0x02003FC2 RID: 16322
		[Token(Token = "0x2003FC2")]
		public class VirtualView : AVGChatVirtualView<SiracusaChatNarrationComp>
		{
			// Token: 0x060194D9 RID: 103641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194D9")]
			[Address(RVA = "0x12122B0", Offset = "0x1210EB0", VA = "0x1812122B0")]
			public VirtualView(SiracusaChatNarrationComp.ViewModel model)
			{
			}

			// Token: 0x060194DA RID: 103642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194DA")]
			[Address(RVA = "0x120F9F0", Offset = "0x120E5F0", VA = "0x18120F9F0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060194DB RID: 103643 RVA: 0x0009DA70 File Offset: 0x0009BC70
			[Token(Token = "0x60194DB")]
			[Address(RVA = "0x120FFF0", Offset = "0x120EBF0", VA = "0x18120FFF0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060194DC RID: 103644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194DC")]
			[Address(RVA = "0x12108E0", Offset = "0x120F4E0", VA = "0x1812108E0", Slot = "22")]
			protected override void OnUpdateView(SiracusaChatNarrationComp view)
			{
			}

			// Token: 0x060194DD RID: 103645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194DD")]
			[Address(RVA = "0x1210420", Offset = "0x120F020", VA = "0x181210420", Slot = "20")]
			protected override void HideViewContent(SiracusaChatNarrationComp view)
			{
			}

			// Token: 0x060194DE RID: 103646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194DE")]
			[Address(RVA = "0x1211250", Offset = "0x120FE50", VA = "0x181211250", Slot = "21")]
			protected override IEnumerator PlayViewContent(SiracusaChatNarrationComp view)
			{
				return null;
			}

			// Token: 0x060194DF RID: 103647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194DF")]
			[Address(RVA = "0x1211390", Offset = "0x120FF90", VA = "0x181211390", Slot = "23")]
			protected override void ShowAsLog(SiracusaChatNarrationComp view)
			{
			}

			// Token: 0x060194E0 RID: 103648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194E0")]
			[Address(RVA = "0x12115D0", Offset = "0x12101D0", VA = "0x1812115D0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0401F6F0 RID: 128752
			[Token(Token = "0x401F6F0")]
			[FieldOffset(Offset = "0x28")]
			private readonly SiracusaChatNarrationComp.ViewModel m_model;

			// Token: 0x0401F6F1 RID: 128753
			[Token(Token = "0x401F6F1")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isInited;

			// Token: 0x0401F6F2 RID: 128754
			[Token(Token = "0x401F6F2")]
			[FieldOffset(Offset = "0x38")]
			private SiracusaChatNarrationComp.PreferSizeCalculator m_sizeCalculator;

			// Token: 0x0401F6F3 RID: 128755
			[Token(Token = "0x401F6F3")]
			[FieldOffset(Offset = "0x40")]
			private string m_narrationContent;

			// Token: 0x0401F6F4 RID: 128756
			[Token(Token = "0x401F6F4")]
			[FieldOffset(Offset = "0x48")]
			private float m_cachedSize;

			// Token: 0x0401F6F5 RID: 128757
			[Token(Token = "0x401F6F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F6F6 RID: 128758
			[Token(Token = "0x401F6F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401F6F7 RID: 128759
			[Token(Token = "0x401F6F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401F6F8 RID: 128760
			[Token(Token = "0x401F6F8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401F6F9 RID: 128761
			[Token(Token = "0x401F6F9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401F6FA RID: 128762
			[Token(Token = "0x401F6FA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401F6FB RID: 128763
			[Token(Token = "0x401F6FB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0401F6FC RID: 128764
			[Token(Token = "0x401F6FC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__InitIfNot;
		}

		// Token: 0x02003FC4 RID: 16324
		[Token(Token = "0x2003FC4")]
		private class PreferSizeCalculator : IHotfixable
		{
			// Token: 0x060194E7 RID: 103655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194E7")]
			[Address(RVA = "0x11FFB30", Offset = "0x11FE730", VA = "0x1811FFB30")]
			public PreferSizeCalculator(SiracusaChatNarrationComp view)
			{
			}

			// Token: 0x060194E8 RID: 103656 RVA: 0x0009DAA0 File Offset: 0x0009BCA0
			[Token(Token = "0x60194E8")]
			[Address(RVA = "0x11FF980", Offset = "0x11FE580", VA = "0x1811FF980")]
			public float CalcSize(string content)
			{
				return 0f;
			}

			// Token: 0x0401F701 RID: 128769
			[Token(Token = "0x401F701")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0401F702 RID: 128770
			[Token(Token = "0x401F702")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0401F703 RID: 128771
			[Token(Token = "0x401F703")]
			[FieldOffset(Offset = "0x78")]
			private float m_textPadding;

			// Token: 0x0401F704 RID: 128772
			[Token(Token = "0x401F704")]
			[FieldOffset(Offset = "0x80")]
			private SiracusaChatNarrationComp m_view;

			// Token: 0x0401F705 RID: 128773
			[Token(Token = "0x401F705")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F706 RID: 128774
			[Token(Token = "0x401F706")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
