using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x020015FD RID: 5629
	[Token(Token = "0x20015FD")]
	public class LuaActivityEntry : ActivityCommonEntry, IContextHost
	{
		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06007FBB RID: 32699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007FBC RID: 32700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F1F")]
		[Inspect]
		private LuaLayout _dragLuaLayoutHere
		{
			[Token(Token = "0x6007FBB")]
			[Address(RVA = "0x288B010", Offset = "0x2889C10", VA = "0x18288B010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007FBC")]
			[Address(RVA = "0x288B180", Offset = "0x2889D80", VA = "0x18288B180")]
			set
			{
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06007FBD RID: 32701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F20")]
		public Transform root
		{
			[Token(Token = "0x6007FBD")]
			[Address(RVA = "0x288B120", Offset = "0x2889D20", VA = "0x18288B120", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F21")]
		public string mainDialog
		{
			[Token(Token = "0x6007FBE")]
			[Address(RVA = "0x288B070", Offset = "0x2889C70", VA = "0x18288B070", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FBF")]
		[Address(RVA = "0x288A4E0", Offset = "0x28890E0", VA = "0x18288A4E0", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC0")]
		[Address(RVA = "0x288A790", Offset = "0x2889390", VA = "0x18288A790", Slot = "5")]
		public override void OnResume()
		{
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC1")]
		[Address(RVA = "0x288A6A0", Offset = "0x28892A0", VA = "0x18288A6A0", Slot = "6")]
		public override void OnExit()
		{
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x00038208 File Offset: 0x00036408
		[Token(Token = "0x6007FC2")]
		[Address(RVA = "0x288A9F0", Offset = "0x28895F0", VA = "0x18288A9F0", Slot = "7")]
		public override bool TryDismissBackPress()
		{
			return default(bool);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC3")]
		[Address(RVA = "0x288A730", Offset = "0x2889330", VA = "0x18288A730", Slot = "11")]
		public void OnLeaveContext()
		{
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FC4")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC5")]
		[Address(RVA = "0x288ABF0", Offset = "0x28897F0", VA = "0x18288ABF0", Slot = "10")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FC6")]
		[Address(RVA = "0x288AC80", Offset = "0x2889880", VA = "0x18288AC80")]
		private string _GetMainDialogClass()
		{
			return null;
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FC7")]
		[Address(RVA = "0x288A870", Offset = "0x2889470", VA = "0x18288A870")]
		public static void StartStoryWithSyncMusic(string storyId)
		{
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FC8")]
		[Address(RVA = "0x288A3D0", Offset = "0x2888FD0", VA = "0x18288A3D0", Slot = "14")]
		public IDictionary<string, Type> CompDeclaration()
		{
			return null;
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FC9")]
		[Address(RVA = "0x288AB90", Offset = "0x2889790", VA = "0x18288AB90", Slot = "15")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCA")]
		[Address(RVA = "0x288AFB0", Offset = "0x2889BB0", VA = "0x18288AFB0")]
		public LuaActivityEntry()
		{
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCB")]
		[Address(RVA = "0x288AB70", Offset = "0x2889770", VA = "0x18288AB70")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCC")]
		[Address(RVA = "0x288AB60", Offset = "0x2889760", VA = "0x18288AB60")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06007FCD RID: 32717 RVA: 0x00038220 File Offset: 0x00036420
		[Token(Token = "0x6007FCD")]
		[Address(RVA = "0x288AB80", Offset = "0x2889780", VA = "0x18288AB80")]
		private bool <>xLuaBaseProxy_TryDismissBackPress()
		{
			return default(bool);
		}

		// Token: 0x0400812F RID: 33071
		[Token(Token = "0x400812F")]
		public const string KEY_DISMISS_CONTROL = "key_dismiss_control";

		// Token: 0x04008130 RID: 33072
		[Token(Token = "0x4008130")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ReadOnly]
		[Obsolete("Use activity id and path instead")]
		private string _mainDialog;

		// Token: 0x04008131 RID: 33073
		[Token(Token = "0x4008131")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Use _dragLuaLayoutHere to auto generate")]
		private string _activityId;

		// Token: 0x04008132 RID: 33074
		[Token(Token = "0x4008132")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Use _dragLuaLayoutHere to auto generate")]
		private string _dlgPath;

		// Token: 0x04008133 RID: 33075
		[Token(Token = "0x4008133")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Set lua cls to this if a speical base class should be applied")]
		private string _overrideBaseCls;

		// Token: 0x04008134 RID: 33076
		[Token(Token = "0x4008134")]
		[FieldOffset(Offset = "0x60")]
		private LuaUIContext m_context;

		// Token: 0x04008135 RID: 33077
		[Token(Token = "0x4008135")]
		[FieldOffset(Offset = "0x68")]
		private string m_mainDialogCls;

		// Token: 0x04008136 RID: 33078
		[Token(Token = "0x4008136")]
		[FieldOffset(Offset = "0x70")]
		private LuaActivityEntry.IDismissControl m_luaBridge;

		// Token: 0x04008137 RID: 33079
		[Token(Token = "0x4008137")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__dragLuaLayoutHere;

		// Token: 0x04008138 RID: 33080
		[Token(Token = "0x4008138")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set__dragLuaLayoutHere;

		// Token: 0x04008139 RID: 33081
		[Token(Token = "0x4008139")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x0400813A RID: 33082
		[Token(Token = "0x400813A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mainDialog;

		// Token: 0x0400813B RID: 33083
		[Token(Token = "0x400813B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400813C RID: 33084
		[Token(Token = "0x400813C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400813D RID: 33085
		[Token(Token = "0x400813D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400813E RID: 33086
		[Token(Token = "0x400813E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryDismissBackPress;

		// Token: 0x0400813F RID: 33087
		[Token(Token = "0x400813F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnLeaveContext;

		// Token: 0x04008140 RID: 33088
		[Token(Token = "0x4008140")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x04008141 RID: 33089
		[Token(Token = "0x4008141")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x04008142 RID: 33090
		[Token(Token = "0x4008142")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetMainDialogClass;

		// Token: 0x04008143 RID: 33091
		[Token(Token = "0x4008143")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_StartStoryWithSyncMusic;

		// Token: 0x04008144 RID: 33092
		[Token(Token = "0x4008144")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CompDeclaration;

		// Token: 0x04008145 RID: 33093
		[Token(Token = "0x4008145")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UICompDialogHost;

		// Token: 0x04008146 RID: 33094
		[Token(Token = "0x4008146")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020015FE RID: 5630
		[Token(Token = "0x20015FE")]
		[CSharpCallLua]
		public interface IDismissControl
		{
			// Token: 0x06007FCE RID: 32718
			[Token(Token = "0x6007FCE")]
			bool TryDismiss();
		}

		// Token: 0x020015FF RID: 5631
		[Token(Token = "0x20015FF")]
		private class DismissControl : LuaUIContext.Comp
		{
			// Token: 0x06007FCF RID: 32719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCF")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void Bind(LuaActivityEntry.IDismissControl luaBridge)
			{
			}

			// Token: 0x06007FD0 RID: 32720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DismissControl()
			{
			}
		}
	}
}
