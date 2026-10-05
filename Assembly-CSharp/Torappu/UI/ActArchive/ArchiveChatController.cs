using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B3D RID: 27453
	[Token(Token = "0x2006B3D")]
	public class ArchiveChatController : ActArchiveController
	{
		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x060273E6 RID: 160742 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273E7 RID: 160743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CBE")]
		public Action<ActArchiveType, string, ArchiveChatListDataBinder.ChatSwitchDirection> onChatItemClicked
		{
			[Token(Token = "0x60273E6")]
			[Address(RVA = "0x226B780", Offset = "0x226A380", VA = "0x18226B780")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273E7")]
			[Address(RVA = "0x226B7E0", Offset = "0x226A3E0", VA = "0x18226B7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060273E8 RID: 160744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273E8")]
		[Address(RVA = "0x226B560", Offset = "0x226A160", VA = "0x18226B560", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060273E9 RID: 160745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273E9")]
		[Address(RVA = "0x226B5E0", Offset = "0x226A1E0", VA = "0x18226B5E0")]
		public void OnItemClick(string funcId, ArchiveChatListDataBinder.ChatSwitchDirection directionMoveTo)
		{
		}

		// Token: 0x060273EA RID: 160746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60273EA")]
		[Address(RVA = "0x226B110", Offset = "0x2269D10", VA = "0x18226B110")]
		public List<DataBinder<ChatProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060273EB RID: 160747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273EB")]
		[Address(RVA = "0x226B330", Offset = "0x2269F30", VA = "0x18226B330", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060273EC RID: 160748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273EC")]
		[Address(RVA = "0x226B720", Offset = "0x226A320", VA = "0x18226B720")]
		public ArchiveChatController()
		{
		}

		// Token: 0x060273ED RID: 160749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273ED")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060273EE RID: 160750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273EE")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x04037875 RID: 227445
		[Token(Token = "0x4037875")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveChatListDataBinder _chatDataBinder;

		// Token: 0x04037876 RID: 227446
		[Token(Token = "0x4037876")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveChatRecordListDataBinder _charRecordDataBinder;

		// Token: 0x04037877 RID: 227447
		[Token(Token = "0x4037877")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037878 RID: 227448
		[Token(Token = "0x4037878")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403787A RID: 227450
		[Token(Token = "0x403787A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onChatItemClicked;

		// Token: 0x0403787B RID: 227451
		[Token(Token = "0x403787B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onChatItemClicked;

		// Token: 0x0403787C RID: 227452
		[Token(Token = "0x403787C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403787D RID: 227453
		[Token(Token = "0x403787D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_OnItemClick;

		// Token: 0x0403787E RID: 227454
		[Token(Token = "0x403787E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x0403787F RID: 227455
		[Token(Token = "0x403787F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037880 RID: 227456
		[Token(Token = "0x4037880")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
