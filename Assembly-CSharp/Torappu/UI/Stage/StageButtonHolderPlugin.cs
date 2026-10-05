using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200694D RID: 26957
	[Token(Token = "0x200694D")]
	[RequireComponent(typeof(StageButtonOnMapHolder))]
	public abstract class StageButtonHolderPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026971 RID: 158065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026971")]
		[Address(RVA = "0x21A80E0", Offset = "0x21A6CE0", VA = "0x1821A80E0")]
		public StageButtonOnMapHolder.IMessageReceiver GetMessageReceiver()
		{
			return null;
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x06026972 RID: 158066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B1B")]
		protected StageButtonOnMapHolder stageHolder
		{
			[Token(Token = "0x6026972")]
			[Address(RVA = "0x21A8380", Offset = "0x21A6F80", VA = "0x1821A8380")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026973 RID: 158067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026973")]
		[Address(RVA = "0x21A7ED0", Offset = "0x21A6AD0", VA = "0x1821A7ED0")]
		protected StageButtonOnMap.PluginBridge GetButtonPluginBridge()
		{
			return null;
		}

		// Token: 0x06026974 RID: 158068
		[Token(Token = "0x6026974")]
		protected abstract void OnInit();

		// Token: 0x06026975 RID: 158069
		[Token(Token = "0x6026975")]
		protected abstract void OnRenderStage(StageViewModel model);

		// Token: 0x06026976 RID: 158070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026976")]
		[Address(RVA = "0x21A81F0", Offset = "0x21A6DF0", VA = "0x1821A81F0")]
		private void _TriggerInit(StageButtonOnMapHolder holder)
		{
		}

		// Token: 0x06026977 RID: 158071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026977")]
		[Address(RVA = "0x21A8290", Offset = "0x21A6E90", VA = "0x1821A8290")]
		private void _TriggerRenderStage(StageViewModel model)
		{
		}

		// Token: 0x06026978 RID: 158072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026978")]
		[Address(RVA = "0x21A8320", Offset = "0x21A6F20", VA = "0x1821A8320")]
		protected StageButtonHolderPlugin()
		{
		}

		// Token: 0x0403671E RID: 223006
		[Token(Token = "0x403671E")]
		[FieldOffset(Offset = "0x18")]
		private StageButtonHolderPlugin.MessageReceiver m_receiver;

		// Token: 0x0403671F RID: 223007
		[Token(Token = "0x403671F")]
		[FieldOffset(Offset = "0x20")]
		private StageButtonOnMapHolder m_holder;

		// Token: 0x04036720 RID: 223008
		[Token(Token = "0x4036720")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMessageReceiver;

		// Token: 0x04036721 RID: 223009
		[Token(Token = "0x4036721")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageHolder;

		// Token: 0x04036722 RID: 223010
		[Token(Token = "0x4036722")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetButtonPluginBridge;

		// Token: 0x04036723 RID: 223011
		[Token(Token = "0x4036723")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerInit;

		// Token: 0x04036724 RID: 223012
		[Token(Token = "0x4036724")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerRenderStage;

		// Token: 0x04036725 RID: 223013
		[Token(Token = "0x4036725")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200694E RID: 26958
		[Token(Token = "0x200694E")]
		private class MessageReceiver : StageButtonOnMapHolder.IMessageReceiver, IHotfixable
		{
			// Token: 0x06026979 RID: 158073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026979")]
			[Address(RVA = "0x21A7150", Offset = "0x21A5D50", VA = "0x1821A7150")]
			public MessageReceiver(StageButtonHolderPlugin closure)
			{
			}

			// Token: 0x0602697A RID: 158074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602697A")]
			[Address(RVA = "0x21A6FA0", Offset = "0x21A5BA0", VA = "0x1821A6FA0", Slot = "4")]
			public void OnInit(StageButtonOnMapHolder holder)
			{
			}

			// Token: 0x0602697B RID: 158075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602697B")]
			[Address(RVA = "0x21A7080", Offset = "0x21A5C80", VA = "0x1821A7080", Slot = "5")]
			public void OnRenderStage(StageViewModel model)
			{
			}

			// Token: 0x04036726 RID: 223014
			[Token(Token = "0x4036726")]
			[FieldOffset(Offset = "0x10")]
			private StageButtonHolderPlugin m_closure;

			// Token: 0x04036727 RID: 223015
			[Token(Token = "0x4036727")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036728 RID: 223016
			[Token(Token = "0x4036728")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04036729 RID: 223017
			[Token(Token = "0x4036729")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRenderStage;
		}
	}
}
