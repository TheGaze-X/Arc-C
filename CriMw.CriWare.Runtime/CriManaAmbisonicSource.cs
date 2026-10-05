using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class CriManaAmbisonicSource : CriMonoBehaviour
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x36FE3E0", Offset = "0x36FCFE0", VA = "0x1836FE3E0", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x36FE530", Offset = "0x36FD130", VA = "0x1836FE530", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x36FE490", Offset = "0x36FD090", VA = "0x1836FE490")]
		private void ForceUpdateAmbisonicSourceOrientation()
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x36FE3E0", Offset = "0x36FCFE0", VA = "0x1836FE3E0")]
		private void UpdateAmbisonicSourceOrientation()
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x36FE630", Offset = "0x36FD230", VA = "0x1836FE630")]
		private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler)
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x36FB5A0", Offset = "0x36FA1A0", VA = "0x1836FB5A0")]
		public CriManaAmbisonicSource()
		{
		}

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x28")]
		private CriAtomEx3dSource atomEx3DsourceForAmbisonics;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 ambisonicSourceOrientationFront;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 ambisonicSourceOrientationTop;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 lastEulerOfAmbisonicSource;
	}
}
