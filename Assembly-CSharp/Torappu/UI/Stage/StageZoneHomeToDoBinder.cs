using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067C1 RID: 26561
	[Token(Token = "0x20067C1")]
	public class StageZoneHomeToDoBinder : DataBinder<ZoneHomeToDoGroupProp>
	{
		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x06026174 RID: 156020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026175 RID: 156021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A14")]
		public Action<ZoneHomeToDoItemModel> onToDoClicked
		{
			[Token(Token = "0x6026174")]
			[Address(RVA = "0x2125260", Offset = "0x2123E60", VA = "0x182125260")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026175")]
			[Address(RVA = "0x21252C0", Offset = "0x2123EC0", VA = "0x1821252C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026176 RID: 156022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026176")]
		[Address(RVA = "0x2124F20", Offset = "0x2123B20", VA = "0x182124F20", Slot = "7")]
		public override void OnValueChanged(ZoneHomeToDoGroupProp property)
		{
		}

		// Token: 0x06026177 RID: 156023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026177")]
		[Address(RVA = "0x21250D0", Offset = "0x2123CD0", VA = "0x1821250D0")]
		private void _OnToDoClicked(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026178")]
		[Address(RVA = "0x21251F0", Offset = "0x2123DF0", VA = "0x1821251F0")]
		public StageZoneHomeToDoBinder()
		{
		}

		// Token: 0x040359D9 RID: 219609
		[Token(Token = "0x40359D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageZoneHomeToDoLayout _layout;

		// Token: 0x040359DB RID: 219611
		[Token(Token = "0x40359DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToDoClicked;

		// Token: 0x040359DC RID: 219612
		[Token(Token = "0x40359DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToDoClicked;

		// Token: 0x040359DD RID: 219613
		[Token(Token = "0x40359DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040359DE RID: 219614
		[Token(Token = "0x40359DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToDoClicked;

		// Token: 0x040359DF RID: 219615
		[Token(Token = "0x40359DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
