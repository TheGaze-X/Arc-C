using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003384 RID: 13188
	[Token(Token = "0x2003384")]
	public class UIHpFillImage : Image, IHotfixable
	{
		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x06015089 RID: 86153 RVA: 0x0008A228 File Offset: 0x00088428
		// (set) Token: 0x0601508A RID: 86154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031F9")]
		public float splitValue
		{
			[Token(Token = "0x6015089")]
			[Address(RVA = "0xD743D0", Offset = "0xD72FD0", VA = "0x180D743D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601508A")]
			[Address(RVA = "0xD74430", Offset = "0xD73030", VA = "0x180D74430")]
			set
			{
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0601508B RID: 86155 RVA: 0x0008A240 File Offset: 0x00088440
		[Token(Token = "0x170031FA")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601508B")]
			[Address(RVA = "0xD74370", Offset = "0xD72F70", VA = "0x180D74370", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601508C")]
		[Address(RVA = "0xD74130", Offset = "0xD72D30", VA = "0x180D74130", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x0601508D RID: 86157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601508D")]
		[Address(RVA = "0xD742F0", Offset = "0xD72EF0", VA = "0x180D742F0")]
		public UIHpFillImage()
		{
		}

		// Token: 0x0601508E RID: 86158 RVA: 0x0008A258 File Offset: 0x00088458
		[Token(Token = "0x601508E")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x0601508F RID: 86159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601508F")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x04019082 RID: 102530
		[Token(Token = "0x4019082")]
		[FieldOffset(Offset = "0x190")]
		private float m_splitValue;

		// Token: 0x04019083 RID: 102531
		[Token(Token = "0x4019083")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_splitValue;

		// Token: 0x04019084 RID: 102532
		[Token(Token = "0x4019084")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_splitValue;

		// Token: 0x04019085 RID: 102533
		[Token(Token = "0x4019085")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x04019086 RID: 102534
		[Token(Token = "0x4019086")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x04019087 RID: 102535
		[Token(Token = "0x4019087")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
