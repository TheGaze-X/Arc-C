using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020034B7 RID: 13495
	[Token(Token = "0x20034B7")]
	public class UIBlendRTImage : Image
	{
		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0601581E RID: 88094 RVA: 0x0008C550 File Offset: 0x0008A750
		[Token(Token = "0x170032CA")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601581E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0601581F RID: 88095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015820 RID: 88096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032CB")]
		public override Material material
		{
			[Token(Token = "0x601581F")]
			[Address(RVA = "0xE09AB0", Offset = "0xE086B0", VA = "0x180E09AB0", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015820")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x06015821 RID: 88097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015821")]
		[Address(RVA = "0xE09860", Offset = "0xE08460", VA = "0x180E09860", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x06015822 RID: 88098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015822")]
		[Address(RVA = "0xE099A0", Offset = "0xE085A0", VA = "0x180E099A0")]
		private void _UpdateMaterial()
		{
		}

		// Token: 0x06015823 RID: 88099 RVA: 0x0008C568 File Offset: 0x0008A768
		[Token(Token = "0x6015823")]
		[Address(RVA = "0xE09910", Offset = "0xE08510", VA = "0x180E09910")]
		private bool _IsMeshDisabled()
		{
			return default(bool);
		}

		// Token: 0x06015824 RID: 88100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015824")]
		[Address(RVA = "0xE096A0", Offset = "0xE082A0", VA = "0x180E096A0")]
		public void HostOnly_Bind(UIBlendRTHost host)
		{
		}

		// Token: 0x06015825 RID: 88101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015825")]
		[Address(RVA = "0xE097F0", Offset = "0xE083F0", VA = "0x180E097F0")]
		public void HostOnly_Unbind(UIBlendRTHost host)
		{
		}

		// Token: 0x06015826 RID: 88102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015826")]
		[Address(RVA = "0xE09780", Offset = "0xE08380", VA = "0x180E09780")]
		public void HostOnly_SetRTEnabled(bool isEnabled)
		{
		}

		// Token: 0x06015827 RID: 88103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015827")]
		[Address(RVA = "0xE09A60", Offset = "0xE08660", VA = "0x180E09A60")]
		public UIBlendRTImage()
		{
		}

		// Token: 0x04019C5D RID: 105565
		[Token(Token = "0x4019C5D")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private UIBlendRTHost.BlendWeight _weight;

		// Token: 0x04019C5E RID: 105566
		[Token(Token = "0x4019C5E")]
		[FieldOffset(Offset = "0x198")]
		private UIBlendRTHost m_host;

		// Token: 0x04019C5F RID: 105567
		[Token(Token = "0x4019C5F")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_isRTEnabled;

		// Token: 0x04019C60 RID: 105568
		[Token(Token = "0x4019C60")]
		[FieldOffset(Offset = "0x1A8")]
		private Material m_matForRT;
	}
}
