using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Lua;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038C6 RID: 14534
	[Token(Token = "0x20038C6")]
	public class LuaVirtualViewAdapter : UIRecycleLayoutAdapter, IDisposable
	{
		// Token: 0x06016FCB RID: 94155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016FCB")]
		[Address(RVA = "0xF73E70", Offset = "0xF72A70", VA = "0x180F73E70", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06016FCC RID: 94156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FCC")]
		[Address(RVA = "0xF73DD0", Offset = "0xF729D0", VA = "0x180F73DD0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06016FCD RID: 94157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FCD")]
		[Address(RVA = "0xF740C0", Offset = "0xF72CC0", VA = "0x180F740C0")]
		private void _BindViewToLua(LuaVirtualViewAdapter.VirtualView view, LuaLayout layout)
		{
		}

		// Token: 0x06016FCE RID: 94158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FCE")]
		[Address(RVA = "0xF74940", Offset = "0xF73540", VA = "0x180F74940")]
		private void _RebuildAllViews()
		{
		}

		// Token: 0x06016FCF RID: 94159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FCF")]
		[Address(RVA = "0xF74770", Offset = "0xF73370", VA = "0x180F74770")]
		private void _InsertView(int indexFrom1, int viewType, float initSize)
		{
		}

		// Token: 0x06016FD0 RID: 94160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FD0")]
		[Address(RVA = "0xF73F80", Offset = "0xF72B80", VA = "0x180F73F80")]
		private void _AddView(int viewType, float initSize)
		{
		}

		// Token: 0x06016FD1 RID: 94161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FD1")]
		[Address(RVA = "0xF74B00", Offset = "0xF73700", VA = "0x180F74B00")]
		private void _RemoveView(int indexFrom1)
		{
		}

		// Token: 0x06016FD2 RID: 94162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FD2")]
		[Address(RVA = "0xF74A00", Offset = "0xF73600", VA = "0x180F74A00")]
		private void _RemoveAllViews()
		{
		}

		// Token: 0x06016FD3 RID: 94163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FD3")]
		[Address(RVA = "0xF73ED0", Offset = "0xF72AD0", VA = "0x180F73ED0")]
		private void _AddViewTypeDefine(int viewType, LuaLayout prefab)
		{
		}

		// Token: 0x06016FD4 RID: 94164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FD4")]
		[Address(RVA = "0xF74C40", Offset = "0xF73840", VA = "0x180F74C40")]
		private LuaVirtualViewAdapter(LuaVirtualViewAdapter.ILuaObject luaObj)
		{
		}

		// Token: 0x06016FD5 RID: 94165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016FD5")]
		[Address(RVA = "0xF74610", Offset = "0xF73210", VA = "0x180F74610")]
		private LuaVirtualViewAdapter.Context _EnsureContext()
		{
			return null;
		}

		// Token: 0x06016FD6 RID: 94166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016FD6")]
		[Address(RVA = "0xF742B0", Offset = "0xF72EB0", VA = "0x180F742B0")]
		private LuaVirtualViewAdapter.VirtualView _CreateVirtualView(int viewType, float initSize)
		{
			return null;
		}

		// Token: 0x0401BC00 RID: 113664
		[Token(Token = "0x401BC00")]
		[FieldOffset(Offset = "0x18")]
		private LuaVirtualViewAdapter.ILuaObject m_luaObj;

		// Token: 0x0401BC01 RID: 113665
		[Token(Token = "0x401BC01")]
		[FieldOffset(Offset = "0x20")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

		// Token: 0x0401BC02 RID: 113666
		[Token(Token = "0x401BC02")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<int, LuaLayout> m_viewTypeToPrefab;

		// Token: 0x0401BC03 RID: 113667
		[Token(Token = "0x401BC03")]
		[FieldOffset(Offset = "0x30")]
		private LuaVirtualViewAdapter.Context m_context;

		// Token: 0x0401BC04 RID: 113668
		[Token(Token = "0x401BC04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0401BC05 RID: 113669
		[Token(Token = "0x401BC05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401BC06 RID: 113670
		[Token(Token = "0x401BC06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BindViewToLua;

		// Token: 0x0401BC07 RID: 113671
		[Token(Token = "0x401BC07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RebuildAllViews;

		// Token: 0x0401BC08 RID: 113672
		[Token(Token = "0x401BC08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InsertView;

		// Token: 0x0401BC09 RID: 113673
		[Token(Token = "0x401BC09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddView;

		// Token: 0x0401BC0A RID: 113674
		[Token(Token = "0x401BC0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RemoveView;

		// Token: 0x0401BC0B RID: 113675
		[Token(Token = "0x401BC0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveAllViews;

		// Token: 0x0401BC0C RID: 113676
		[Token(Token = "0x401BC0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddViewTypeDefine;

		// Token: 0x0401BC0D RID: 113677
		[Token(Token = "0x401BC0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401BC0E RID: 113678
		[Token(Token = "0x401BC0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EnsureContext;

		// Token: 0x0401BC0F RID: 113679
		[Token(Token = "0x401BC0F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateVirtualView;

		// Token: 0x020038C7 RID: 14535
		[Token(Token = "0x20038C7")]
		public class CSharpInterface : ILuaCallCSharp
		{
			// Token: 0x06016FD7 RID: 94167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FD7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private CSharpInterface()
			{
			}

			// Token: 0x06016FD8 RID: 94168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FD8")]
			[Address(RVA = "0xF6F2C0", Offset = "0xF6DEC0", VA = "0x180F6F2C0")]
			public void DisposeFromLua()
			{
			}

			// Token: 0x06016FD9 RID: 94169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FD9")]
			[Address(RVA = "0xF6ED10", Offset = "0xF6D910", VA = "0x180F6ED10")]
			public void AddViewTypeDefine(int viewType, LuaLayout prefab)
			{
			}

			// Token: 0x06016FDA RID: 94170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FDA")]
			[Address(RVA = "0xF6F310", Offset = "0xF6DF10", VA = "0x180F6F310")]
			public void RebuildAllViews()
			{
			}

			// Token: 0x06016FDB RID: 94171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FDB")]
			[Address(RVA = "0xF6EDD0", Offset = "0xF6D9D0", VA = "0x180F6EDD0")]
			public void AddView(int viewType, float initSize)
			{
			}

			// Token: 0x06016FDC RID: 94172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FDC")]
			[Address(RVA = "0xF6F2E0", Offset = "0xF6DEE0", VA = "0x180F6F2E0")]
			public void InsertView(int indexFrom1, int viewType, float initSize)
			{
			}

			// Token: 0x06016FDD RID: 94173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FDD")]
			[Address(RVA = "0xF6F4F0", Offset = "0xF6E0F0", VA = "0x180F6F4F0")]
			public void RemoveView(int indexFrom1)
			{
			}

			// Token: 0x06016FDE RID: 94174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FDE")]
			[Address(RVA = "0xF6F3E0", Offset = "0xF6DFE0", VA = "0x180F6F3E0")]
			public void RemoveAllViews()
			{
			}

			// Token: 0x06016FDF RID: 94175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016FDF")]
			[Address(RVA = "0xF6EF10", Offset = "0xF6DB10", VA = "0x180F6EF10")]
			public static LuaVirtualViewAdapter.CSharpInterface BindAdapterToLayout(LuaVirtualViewAdapter.ILuaObject luaObj, UIRecycleLayoutGroup layout)
			{
				return null;
			}

			// Token: 0x0401BC10 RID: 113680
			[Token(Token = "0x401BC10")]
			[FieldOffset(Offset = "0x10")]
			private LuaVirtualViewAdapter m_adapter;
		}

		// Token: 0x020038C8 RID: 14536
		[Token(Token = "0x20038C8")]
		public interface ILuaObject : ICSharpCallLua
		{
			// Token: 0x06016FE0 RID: 94176
			[Token(Token = "0x6016FE0")]
			void ExportBindView(int type, int indexFrom1, LuaLayout layout, int widgetId);
		}

		// Token: 0x020038C9 RID: 14537
		[Token(Token = "0x20038C9")]
		private class Context : IHotfixable
		{
			// Token: 0x06016FE1 RID: 94177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FE1")]
			[Address(RVA = "0xF726B0", Offset = "0xF712B0", VA = "0x180F726B0")]
			public Context(LuaVirtualViewAdapter closure)
			{
			}

			// Token: 0x06016FE2 RID: 94178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FE2")]
			[Address(RVA = "0xF72610", Offset = "0xF71210", VA = "0x180F72610")]
			public void BindView(LuaVirtualViewAdapter.VirtualView view, LuaLayout layout)
			{
			}

			// Token: 0x0401BC11 RID: 113681
			[Token(Token = "0x401BC11")]
			[FieldOffset(Offset = "0x10")]
			private LuaVirtualViewAdapter m_closure;

			// Token: 0x0401BC12 RID: 113682
			[Token(Token = "0x401BC12")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BC13 RID: 113683
			[Token(Token = "0x401BC13")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_BindView;
		}

		// Token: 0x020038CA RID: 14538
		[Token(Token = "0x20038CA")]
		private class VirtualView : UIRecycleLayoutAdapter.VirtualView<LuaLayout>, UIRecycleLayoutAdapter.ICustomViewType
		{
			// Token: 0x06016FE3 RID: 94179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FE3")]
			[Address(RVA = "0xF83420", Offset = "0xF82020", VA = "0x180F83420")]
			public VirtualView(int pViewType, LuaLayout prefab, float size, LuaVirtualViewAdapter.Context context)
			{
			}

			// Token: 0x170036E2 RID: 14050
			// (get) Token: 0x06016FE4 RID: 94180 RVA: 0x00094368 File Offset: 0x00092568
			// (set) Token: 0x06016FE5 RID: 94181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036E2")]
			public int viewType
			{
				[Token(Token = "0x6016FE4")]
				[Address(RVA = "0xF83640", Offset = "0xF82240", VA = "0x180F83640", Slot = "14")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6016FE5")]
				[Address(RVA = "0xF836A0", Offset = "0xF822A0", VA = "0x180F836A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016FE6 RID: 94182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016FE6")]
			[Address(RVA = "0xF82EF0", Offset = "0xF81AF0", VA = "0x180F82EF0")]
			public LuaLayout GetAttachedLuaLayout()
			{
				return null;
			}

			// Token: 0x06016FE7 RID: 94183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016FE7")]
			[Address(RVA = "0xF82FD0", Offset = "0xF81BD0", VA = "0x180F82FD0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06016FE8 RID: 94184 RVA: 0x00094380 File Offset: 0x00092580
			[Token(Token = "0x6016FE8")]
			[Address(RVA = "0xF830B0", Offset = "0xF81CB0", VA = "0x180F830B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06016FE9 RID: 94185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FE9")]
			[Address(RVA = "0xF83110", Offset = "0xF81D10", VA = "0x180F83110", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06016FEA RID: 94186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016FEA")]
			[Address(RVA = "0xF833C0", Offset = "0xF81FC0", VA = "0x180F833C0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0401BC14 RID: 113684
			[Token(Token = "0x401BC14")]
			[FieldOffset(Offset = "0x20")]
			private LuaLayout m_prefab;

			// Token: 0x0401BC15 RID: 113685
			[Token(Token = "0x401BC15")]
			[FieldOffset(Offset = "0x28")]
			private float m_size;

			// Token: 0x0401BC16 RID: 113686
			[Token(Token = "0x401BC16")]
			[FieldOffset(Offset = "0x30")]
			private LuaVirtualViewAdapter.Context m_context;

			// Token: 0x0401BC18 RID: 113688
			[Token(Token = "0x401BC18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BC19 RID: 113689
			[Token(Token = "0x401BC19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_viewType;

			// Token: 0x0401BC1A RID: 113690
			[Token(Token = "0x401BC1A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_viewType;

			// Token: 0x0401BC1B RID: 113691
			[Token(Token = "0x401BC1B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetAttachedLuaLayout;

			// Token: 0x0401BC1C RID: 113692
			[Token(Token = "0x401BC1C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401BC1D RID: 113693
			[Token(Token = "0x401BC1D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401BC1E RID: 113694
			[Token(Token = "0x401BC1E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0401BC1F RID: 113695
			[Token(Token = "0x401BC1F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}
	}
}
