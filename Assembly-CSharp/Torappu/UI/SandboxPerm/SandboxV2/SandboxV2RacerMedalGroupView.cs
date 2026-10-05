using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004370 RID: 17264
	[Token(Token = "0x2004370")]
	public class SandboxV2RacerMedalGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A7CD RID: 108493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7CD")]
		[Address(RVA = "0x1396090", Offset = "0x1394C90", VA = "0x181396090")]
		public void Render(List<SandboxV2RacerMedalModel> medalList)
		{
		}

		// Token: 0x0601A7CE RID: 108494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7CE")]
		[Address(RVA = "0x1396250", Offset = "0x1394E50", VA = "0x181396250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A7CF RID: 108495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7CF")]
		[Address(RVA = "0x1396370", Offset = "0x1394F70", VA = "0x181396370")]
		public SandboxV2RacerMedalGroupView()
		{
		}

		// Token: 0x04021B66 RID: 138086
		[Token(Token = "0x4021B66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04021B67 RID: 138087
		[Token(Token = "0x4021B67")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2RacerMedalGroupView.Adapter m_adapter;

		// Token: 0x04021B68 RID: 138088
		[Token(Token = "0x4021B68")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04021B69 RID: 138089
		[Token(Token = "0x4021B69")]
		[FieldOffset(Offset = "0x30")]
		private List<SandboxV2RacerMedalModel> m_cachedMedalList;

		// Token: 0x04021B6A RID: 138090
		[Token(Token = "0x4021B6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021B6B RID: 138091
		[Token(Token = "0x4021B6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021B6C RID: 138092
		[Token(Token = "0x4021B6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004371 RID: 17265
		[Token(Token = "0x2004371")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A7D0 RID: 108496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A7D0")]
			[Address(RVA = "0x1383920", Offset = "0x1382520", VA = "0x181383920")]
			public Adapter(SandboxV2RacerMedalGroupView closure)
			{
			}

			// Token: 0x17003EE7 RID: 16103
			// (get) Token: 0x0601A7D1 RID: 108497 RVA: 0x000A1FA0 File Offset: 0x000A01A0
			[Token(Token = "0x17003EE7")]
			public override int count
			{
				[Token(Token = "0x601A7D1")]
				[Address(RVA = "0x1383A10", Offset = "0x1382610", VA = "0x181383A10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A7D2 RID: 108498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A7D2")]
			[Address(RVA = "0x1383240", Offset = "0x1381E40", VA = "0x181383240", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021B6D RID: 138093
			[Token(Token = "0x4021B6D")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerMedalGroupView m_closure;

			// Token: 0x04021B6E RID: 138094
			[Token(Token = "0x4021B6E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021B6F RID: 138095
			[Token(Token = "0x4021B6F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021B70 RID: 138096
			[Token(Token = "0x4021B70")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
