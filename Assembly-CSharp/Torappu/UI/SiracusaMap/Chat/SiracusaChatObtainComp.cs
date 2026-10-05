using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FC5 RID: 16325
	[Token(Token = "0x2003FC5")]
	public class SiracusaChatObtainComp : SiracusaChatSwitchableComp
	{
		// Token: 0x060194E9 RID: 103657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194E9")]
		[Address(RVA = "0x1208C20", Offset = "0x1207820", VA = "0x181208C20")]
		private void _Render(string name, string description)
		{
		}

		// Token: 0x060194EA RID: 103658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194EA")]
		[Address(RVA = "0x1208D20", Offset = "0x1207920", VA = "0x181208D20")]
		public SiracusaChatObtainComp()
		{
		}

		// Token: 0x0401F707 RID: 128775
		[Token(Token = "0x401F707")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0401F708 RID: 128776
		[Token(Token = "0x401F708")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _contentText;

		// Token: 0x0401F709 RID: 128777
		[Token(Token = "0x401F709")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401F70A RID: 128778
		[Token(Token = "0x401F70A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FC6 RID: 16326
		[Token(Token = "0x2003FC6")]
		public class ViewModel
		{
			// Token: 0x060194EB RID: 103659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194EB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x0401F70B RID: 128779
			[Token(Token = "0x401F70B")]
			[FieldOffset(Offset = "0x10")]
			public SiracusaChatObtainComp prefab;

			// Token: 0x0401F70C RID: 128780
			[Token(Token = "0x401F70C")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x0401F70D RID: 128781
			[Token(Token = "0x401F70D")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x0401F70E RID: 128782
			[Token(Token = "0x401F70E")]
			[FieldOffset(Offset = "0x28")]
			public string description;

			// Token: 0x0401F70F RID: 128783
			[Token(Token = "0x401F70F")]
			[FieldOffset(Offset = "0x30")]
			public string script;

			// Token: 0x0401F710 RID: 128784
			[Token(Token = "0x401F710")]
			[FieldOffset(Offset = "0x38")]
			public bool isObtained;
		}

		// Token: 0x02003FC7 RID: 16327
		[Token(Token = "0x2003FC7")]
		public class VirtualView : AVGChatVirtualView<SiracusaChatObtainComp>
		{
			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x060194EC RID: 103660 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060194ED RID: 103661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C7A")]
			public Action<string> itemObtainEvent
			{
				[Token(Token = "0x60194EC")]
				[Address(RVA = "0x12123D0", Offset = "0x1210FD0", VA = "0x1812123D0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60194ED")]
				[Address(RVA = "0x12124F0", Offset = "0x12110F0", VA = "0x1812124F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060194EE RID: 103662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194EE")]
			[Address(RVA = "0x1212340", Offset = "0x1210F40", VA = "0x181212340")]
			public VirtualView(SiracusaChatObtainComp.ViewModel model)
			{
			}

			// Token: 0x060194EF RID: 103663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194EF")]
			[Address(RVA = "0x120F910", Offset = "0x120E510", VA = "0x18120F910", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060194F0 RID: 103664 RVA: 0x0009DAB8 File Offset: 0x0009BCB8
			[Token(Token = "0x60194F0")]
			[Address(RVA = "0x120FB40", Offset = "0x120E740", VA = "0x18120FB40", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060194F1 RID: 103665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194F1")]
			[Address(RVA = "0x1210E10", Offset = "0x120FA10", VA = "0x181210E10", Slot = "22")]
			protected override void OnUpdateView(SiracusaChatObtainComp view)
			{
			}

			// Token: 0x060194F2 RID: 103666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194F2")]
			[Address(RVA = "0x1210620", Offset = "0x120F220", VA = "0x181210620", Slot = "20")]
			protected override void HideViewContent(SiracusaChatObtainComp view)
			{
			}

			// Token: 0x060194F3 RID: 103667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194F3")]
			[Address(RVA = "0x1210F70", Offset = "0x120FB70", VA = "0x181210F70", Slot = "21")]
			protected override IEnumerator PlayViewContent(SiracusaChatObtainComp view)
			{
				return null;
			}

			// Token: 0x060194F4 RID: 103668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194F4")]
			[Address(RVA = "0x12114B0", Offset = "0x12100B0", VA = "0x1812114B0", Slot = "23")]
			protected override void ShowAsLog(SiracusaChatObtainComp view)
			{
			}

			// Token: 0x060194F5 RID: 103669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194F5")]
			[Address(RVA = "0x12119B0", Offset = "0x12105B0", VA = "0x1812119B0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0401F711 RID: 128785
			[Token(Token = "0x401F711")]
			[FieldOffset(Offset = "0x28")]
			private readonly SiracusaChatObtainComp.ViewModel m_model;

			// Token: 0x0401F712 RID: 128786
			[Token(Token = "0x401F712")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isInited;

			// Token: 0x0401F713 RID: 128787
			[Token(Token = "0x401F713")]
			[FieldOffset(Offset = "0x38")]
			private SiracusaChatObtainComp.PreferSizeCalculator m_sizeCalculator;

			// Token: 0x0401F714 RID: 128788
			[Token(Token = "0x401F714")]
			[FieldOffset(Offset = "0x40")]
			private string m_obtainName;

			// Token: 0x0401F715 RID: 128789
			[Token(Token = "0x401F715")]
			[FieldOffset(Offset = "0x48")]
			private string m_obtainDescription;

			// Token: 0x0401F716 RID: 128790
			[Token(Token = "0x401F716")]
			[FieldOffset(Offset = "0x50")]
			private float m_cachedSize;

			// Token: 0x0401F718 RID: 128792
			[Token(Token = "0x401F718")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_itemObtainEvent;

			// Token: 0x0401F719 RID: 128793
			[Token(Token = "0x401F719")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_itemObtainEvent;

			// Token: 0x0401F71A RID: 128794
			[Token(Token = "0x401F71A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F71B RID: 128795
			[Token(Token = "0x401F71B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401F71C RID: 128796
			[Token(Token = "0x401F71C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401F71D RID: 128797
			[Token(Token = "0x401F71D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401F71E RID: 128798
			[Token(Token = "0x401F71E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401F71F RID: 128799
			[Token(Token = "0x401F71F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401F720 RID: 128800
			[Token(Token = "0x401F720")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0401F721 RID: 128801
			[Token(Token = "0x401F721")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__InitIfNot;
		}

		// Token: 0x02003FC9 RID: 16329
		[Token(Token = "0x2003FC9")]
		private class PreferSizeCalculator : IHotfixable
		{
			// Token: 0x060194FC RID: 103676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194FC")]
			[Address(RVA = "0x11FFCB0", Offset = "0x11FE8B0", VA = "0x1811FFCB0")]
			public PreferSizeCalculator(SiracusaChatObtainComp view)
			{
			}

			// Token: 0x060194FD RID: 103677 RVA: 0x0009DAE8 File Offset: 0x0009BCE8
			[Token(Token = "0x60194FD")]
			[Address(RVA = "0x11FF610", Offset = "0x11FE210", VA = "0x1811FF610")]
			public float CalcSize(string content)
			{
				return 0f;
			}

			// Token: 0x0401F726 RID: 128806
			[Token(Token = "0x401F726")]
			[FieldOffset(Offset = "0x10")]
			private TextGenerator m_textGenerator;

			// Token: 0x0401F727 RID: 128807
			[Token(Token = "0x401F727")]
			[FieldOffset(Offset = "0x18")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0401F728 RID: 128808
			[Token(Token = "0x401F728")]
			[FieldOffset(Offset = "0x78")]
			private float m_textPadding;

			// Token: 0x0401F729 RID: 128809
			[Token(Token = "0x401F729")]
			[FieldOffset(Offset = "0x80")]
			private SiracusaChatObtainComp m_view;

			// Token: 0x0401F72A RID: 128810
			[Token(Token = "0x401F72A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F72B RID: 128811
			[Token(Token = "0x401F72B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CalcSize;
		}
	}
}
