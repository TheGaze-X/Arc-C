using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F77 RID: 16247
	[Token(Token = "0x2003F77")]
	public class SiracusaBigMapLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019350 RID: 103248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019350")]
		[Address(RVA = "0x11E29D0", Offset = "0x11E15D0", VA = "0x1811E29D0")]
		public void Init(SiracusaBigMapLineView.Tools tools)
		{
		}

		// Token: 0x06019351 RID: 103249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019351")]
		[Address(RVA = "0x11E2A50", Offset = "0x11E1650", VA = "0x1811E2A50")]
		public void Render(SiracusaMapPanelMapViewModel viewModel)
		{
		}

		// Token: 0x06019352 RID: 103250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019352")]
		[Address(RVA = "0x11E2D50", Offset = "0x11E1950", VA = "0x1811E2D50")]
		private void _RebuildLines(SiracusaMapPanelMapViewModel viewModel)
		{
		}

		// Token: 0x06019353 RID: 103251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019353")]
		[Address(RVA = "0x11E3850", Offset = "0x11E2450", VA = "0x1811E3850")]
		private void _RefreshAllLineItems(SiracusaMapFocusPolicy policy)
		{
		}

		// Token: 0x06019354 RID: 103252 RVA: 0x0009D3B0 File Offset: 0x0009B5B0
		[Token(Token = "0x6019354")]
		[Address(RVA = "0x11E2B20", Offset = "0x11E1720", VA = "0x1811E2B20")]
		private SiracusaBigMapLineView.LineItem _CreateNewLineItem()
		{
			return default(SiracusaBigMapLineView.LineItem);
		}

		// Token: 0x06019355 RID: 103253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019355")]
		[Address(RVA = "0x11E3B80", Offset = "0x11E2780", VA = "0x1811E3B80")]
		public SiracusaBigMapLineView()
		{
		}

		// Token: 0x0401F41E RID: 128030
		[Token(Token = "0x401F41E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _frontContainer;

		// Token: 0x0401F41F RID: 128031
		[Token(Token = "0x401F41F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backContainer;

		// Token: 0x0401F420 RID: 128032
		[Token(Token = "0x401F420")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SiracusaBigMapLineItem _frontPrefab;

		// Token: 0x0401F421 RID: 128033
		[Token(Token = "0x401F421")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SiracusaBigMapLineItem _backPrefab;

		// Token: 0x0401F422 RID: 128034
		[Token(Token = "0x401F422")]
		[FieldOffset(Offset = "0x38")]
		private SiracusaBigMapLineView.Tools m_tools;

		// Token: 0x0401F423 RID: 128035
		[Token(Token = "0x401F423")]
		[FieldOffset(Offset = "0x40")]
		private SiracusaMapFocusPolicy m_lastFocusPolicy;

		// Token: 0x0401F424 RID: 128036
		[Token(Token = "0x401F424")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, SiracusaBigMapLineView.LineItem> m_lineDict;

		// Token: 0x0401F425 RID: 128037
		[Token(Token = "0x401F425")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<string> m_sharedPointSet;

		// Token: 0x0401F426 RID: 128038
		[Token(Token = "0x401F426")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F427 RID: 128039
		[Token(Token = "0x401F427")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F428 RID: 128040
		[Token(Token = "0x401F428")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RebuildLines;

		// Token: 0x0401F429 RID: 128041
		[Token(Token = "0x401F429")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshAllLineItems;

		// Token: 0x0401F42A RID: 128042
		[Token(Token = "0x401F42A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateNewLineItem;

		// Token: 0x0401F42B RID: 128043
		[Token(Token = "0x401F42B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F78 RID: 16248
		[Token(Token = "0x2003F78")]
		public struct Tools
		{
			// Token: 0x06019356 RID: 103254 RVA: 0x0009D3C8 File Offset: 0x0009B5C8
			[Token(Token = "0x6019356")]
			[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0401F42C RID: 128044
			[Token(Token = "0x401F42C")]
			[FieldOffset(Offset = "0x0")]
			public Func<string, Vector2> getPointPos;
		}

		// Token: 0x02003F79 RID: 16249
		[Token(Token = "0x2003F79")]
		private struct LineItem : IHotfixable
		{
			// Token: 0x06019357 RID: 103255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019357")]
			[Address(RVA = "0x11DFB60", Offset = "0x11DE760", VA = "0x1811DFB60")]
			public void Render(SiracusaBigMapLineItem.Options options)
			{
			}

			// Token: 0x06019358 RID: 103256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019358")]
			[Address(RVA = "0x11DF9E0", Offset = "0x11DE5E0", VA = "0x1811DF9E0")]
			public void Destroy()
			{
			}

			// Token: 0x06019359 RID: 103257 RVA: 0x0009D3E0 File Offset: 0x0009B5E0
			[Token(Token = "0x6019359")]
			[Address(RVA = "0x11DF8B0", Offset = "0x11DE4B0", VA = "0x1811DF8B0")]
			public static SiracusaBigMapLineView.LineItem Create(SiracusaBigMapLineItem front, SiracusaBigMapLineItem back)
			{
				return default(SiracusaBigMapLineView.LineItem);
			}

			// Token: 0x0401F42D RID: 128045
			[Token(Token = "0x401F42D")]
			[FieldOffset(Offset = "0x0")]
			private SiracusaBigMapLineItem m_front;

			// Token: 0x0401F42E RID: 128046
			[Token(Token = "0x401F42E")]
			[FieldOffset(Offset = "0x8")]
			private SiracusaBigMapLineItem m_back;

			// Token: 0x0401F42F RID: 128047
			[Token(Token = "0x401F42F")]
			[FieldOffset(Offset = "0x10")]
			public string fromPoint;

			// Token: 0x0401F430 RID: 128048
			[Token(Token = "0x401F430")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0401F431 RID: 128049
			[Token(Token = "0x401F431")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Destroy;

			// Token: 0x0401F432 RID: 128050
			[Token(Token = "0x401F432")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Create;
		}
	}
}
