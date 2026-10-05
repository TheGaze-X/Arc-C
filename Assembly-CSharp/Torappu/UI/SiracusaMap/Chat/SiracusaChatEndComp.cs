using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FBC RID: 16316
	[Token(Token = "0x2003FBC")]
	public class SiracusaChatEndComp : SiracusaChatSwitchableComp
	{
		// Token: 0x060194C8 RID: 103624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194C8")]
		[Address(RVA = "0x1208A40", Offset = "0x1207640", VA = "0x181208A40")]
		public SiracusaChatEndComp()
		{
		}

		// Token: 0x0401F6D8 RID: 128728
		[Token(Token = "0x401F6D8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _fixedSize;

		// Token: 0x0401F6D9 RID: 128729
		[Token(Token = "0x401F6D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FBD RID: 16317
		[Token(Token = "0x2003FBD")]
		public struct VirtualOptions
		{
			// Token: 0x0401F6DA RID: 128730
			[Token(Token = "0x401F6DA")]
			[FieldOffset(Offset = "0x0")]
			public SiracusaChatEndComp prefab;
		}

		// Token: 0x02003FBE RID: 16318
		[Token(Token = "0x2003FBE")]
		public class VirtualView : AVGChatVirtualView<SiracusaChatEndComp>
		{
			// Token: 0x060194C9 RID: 103625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194C9")]
			[Address(RVA = "0x12120D0", Offset = "0x1210CD0", VA = "0x1812120D0")]
			public VirtualView(SiracusaChatEndComp.VirtualOptions options)
			{
			}

			// Token: 0x060194CA RID: 103626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194CA")]
			[Address(RVA = "0x120FAD0", Offset = "0x120E6D0", VA = "0x18120FAD0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060194CB RID: 103627 RVA: 0x0009DA40 File Offset: 0x0009BC40
			[Token(Token = "0x60194CB")]
			[Address(RVA = "0x12103B0", Offset = "0x120EFB0", VA = "0x1812103B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060194CC RID: 103628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194CC")]
			[Address(RVA = "0x12109E0", Offset = "0x120F5E0", VA = "0x1812109E0", Slot = "22")]
			protected override void OnUpdateView(SiracusaChatEndComp view)
			{
			}

			// Token: 0x060194CD RID: 103629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194CD")]
			[Address(RVA = "0x1210520", Offset = "0x120F120", VA = "0x181210520", Slot = "20")]
			protected override void HideViewContent(SiracusaChatEndComp view)
			{
			}

			// Token: 0x060194CE RID: 103630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60194CE")]
			[Address(RVA = "0x12111A0", Offset = "0x120FDA0", VA = "0x1812111A0", Slot = "21")]
			protected override IEnumerator PlayViewContent(SiracusaChatEndComp view)
			{
				return null;
			}

			// Token: 0x060194CF RID: 103631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60194CF")]
			[Address(RVA = "0x1211300", Offset = "0x120FF00", VA = "0x181211300", Slot = "23")]
			protected override void ShowAsLog(SiracusaChatEndComp view)
			{
			}

			// Token: 0x0401F6DB RID: 128731
			[Token(Token = "0x401F6DB")]
			[FieldOffset(Offset = "0x28")]
			private SiracusaChatEndComp.VirtualOptions m_options;

			// Token: 0x0401F6DC RID: 128732
			[Token(Token = "0x401F6DC")]
			[FieldOffset(Offset = "0x30")]
			private float m_cachedSize;

			// Token: 0x0401F6DD RID: 128733
			[Token(Token = "0x401F6DD")]
			[FieldOffset(Offset = "0x38")]
			private string m_narrationContent;

			// Token: 0x0401F6DE RID: 128734
			[Token(Token = "0x401F6DE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F6DF RID: 128735
			[Token(Token = "0x401F6DF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401F6E0 RID: 128736
			[Token(Token = "0x401F6E0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401F6E1 RID: 128737
			[Token(Token = "0x401F6E1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401F6E2 RID: 128738
			[Token(Token = "0x401F6E2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401F6E3 RID: 128739
			[Token(Token = "0x401F6E3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401F6E4 RID: 128740
			[Token(Token = "0x401F6E4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ShowAsLog;
		}
	}
}
