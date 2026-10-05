using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003805 RID: 14341
	[Token(Token = "0x2003805")]
	public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement
	{
		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06016B77 RID: 93047 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06016B78 RID: 93048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000076")]
		public event Action eventOnPostLayout
		{
			[Token(Token = "0x6016B77")]
			[Address(RVA = "0xF17F10", Offset = "0xF16B10", VA = "0x180F17F10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6016B78")]
			[Address(RVA = "0xF17FF0", Offset = "0xF16BF0", VA = "0x180F17FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06016B79 RID: 93049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B79")]
		[Address(RVA = "0xF176B0", Offset = "0xF162B0", VA = "0x180F176B0", Slot = "20")]
		public void GraphicUpdateComplete()
		{
		}

		// Token: 0x06016B7A RID: 93050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7A")]
		[Address(RVA = "0xF17710", Offset = "0xF16310", VA = "0x180F17710", Slot = "19")]
		public void LayoutComplete()
		{
		}

		// Token: 0x06016B7B RID: 93051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7B")]
		[Address(RVA = "0xF178F0", Offset = "0xF164F0", VA = "0x180F178F0", Slot = "17")]
		public void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06016B7C RID: 93052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7C")]
		[Address(RVA = "0xF17620", Offset = "0xF16220", VA = "0x180F17620")]
		public void DoOnceOnPostLayout(UILayoutDimensionListener.IAction action)
		{
		}

		// Token: 0x06016B7D RID: 93053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7D")]
		[Address(RVA = "0xF17810", Offset = "0xF16410", VA = "0x180F17810", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016B7E RID: 93054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7E")]
		[Address(RVA = "0xF17880", Offset = "0xF16480", VA = "0x180F17880", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016B7F RID: 93055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B7F")]
		[Address(RVA = "0xF17770", Offset = "0xF16370", VA = "0x180F17770", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06016B80 RID: 93056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B80")]
		[Address(RVA = "0xF17DB0", Offset = "0xF169B0", VA = "0x180F17DB0")]
		private void _SetDirty()
		{
		}

		// Token: 0x06016B81 RID: 93057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B81")]
		[Address(RVA = "0xF17AA0", Offset = "0xF166A0", VA = "0x180F17AA0")]
		private void _InvokePostLayoutCallback()
		{
		}

		// Token: 0x06016B82 RID: 93058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B82")]
		[Address(RVA = "0xF17E60", Offset = "0xF16A60", VA = "0x180F17E60")]
		public UILayoutDimensionListener()
		{
		}

		// Token: 0x06016B83 RID: 93059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B83")]
		[Address(RVA = "0xF17A40", Offset = "0xF16640", VA = "0x180F17A40", Slot = "18")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06016B84 RID: 93060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B84")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06016B85 RID: 93061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B85")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06016B86 RID: 93062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B86")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0401B5F7 RID: 112119
		[Token(Token = "0x401B5F7")]
		[FieldOffset(Offset = "0x18")]
		private ListSet<UILayoutDimensionListener.IAction> m_actionsWhenLayoutReady;

		// Token: 0x0401B5F9 RID: 112121
		[Token(Token = "0x401B5F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eventOnPostLayout;

		// Token: 0x0401B5FA RID: 112122
		[Token(Token = "0x401B5FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eventOnPostLayout;

		// Token: 0x0401B5FB RID: 112123
		[Token(Token = "0x401B5FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GraphicUpdateComplete;

		// Token: 0x0401B5FC RID: 112124
		[Token(Token = "0x401B5FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LayoutComplete;

		// Token: 0x0401B5FD RID: 112125
		[Token(Token = "0x401B5FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Rebuild;

		// Token: 0x0401B5FE RID: 112126
		[Token(Token = "0x401B5FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoOnceOnPostLayout;

		// Token: 0x0401B5FF RID: 112127
		[Token(Token = "0x401B5FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B600 RID: 112128
		[Token(Token = "0x401B600")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0401B601 RID: 112129
		[Token(Token = "0x401B601")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B602 RID: 112130
		[Token(Token = "0x401B602")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetDirty;

		// Token: 0x0401B603 RID: 112131
		[Token(Token = "0x401B603")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InvokePostLayoutCallback;

		// Token: 0x0401B604 RID: 112132
		[Token(Token = "0x401B604")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B605 RID: 112133
		[Token(Token = "0x401B605")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge get_transform;

		// Token: 0x02003806 RID: 14342
		[Token(Token = "0x2003806")]
		public interface IAction
		{
			// Token: 0x06016B87 RID: 93063
			[Token(Token = "0x6016B87")]
			void DoAction();
		}

		// Token: 0x02003807 RID: 14343
		[Token(Token = "0x2003807")]
		public interface ILuaComponent : ICSharpCallLua
		{
			// Token: 0x06016B88 RID: 93064
			[Token(Token = "0x6016B88")]
			void ExportOnPostLayout();
		}

		// Token: 0x02003808 RID: 14344
		[Token(Token = "0x2003808")]
		public class CSharpInterface : ILuaCallCSharp
		{
			// Token: 0x06016B89 RID: 93065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B89")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private CSharpInterface()
			{
			}

			// Token: 0x06016B8A RID: 93066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B8A")]
			[Address(RVA = "0xF056A0", Offset = "0xF042A0", VA = "0x180F056A0")]
			public void DisposeFromLua()
			{
			}

			// Token: 0x06016B8B RID: 93067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B8B")]
			[Address(RVA = "0xF05850", Offset = "0xF04450", VA = "0x180F05850")]
			private void _OnPostLayout()
			{
			}

			// Token: 0x06016B8C RID: 93068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016B8C")]
			[Address(RVA = "0xF054D0", Offset = "0xF040D0", VA = "0x180F054D0")]
			public static UILayoutDimensionListener.CSharpInterface BindToListener(UILayoutDimensionListener.ILuaComponent luaObj, UILayoutDimensionListener listener)
			{
				return null;
			}

			// Token: 0x0401B606 RID: 112134
			[Token(Token = "0x401B606")]
			[FieldOffset(Offset = "0x10")]
			private UILayoutDimensionListener.ILuaComponent m_luaObj;

			// Token: 0x0401B607 RID: 112135
			[Token(Token = "0x401B607")]
			[FieldOffset(Offset = "0x18")]
			private UILayoutDimensionListener m_listener;
		}
	}
}
