using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.XR;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[Serializable]
	public class XRDeviceDescriptor
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x56B5700", Offset = "0x56B4300", VA = "0x1856B5700")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x56B56C0", Offset = "0x56B42C0", VA = "0x1856B56C0")]
		public static XRDeviceDescriptor FromJson(string json)
		{
			return null;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XRDeviceDescriptor()
		{
		}

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x10")]
		public string deviceName;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x18")]
		public string manufacturer;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x20")]
		public string serialNumber;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x28")]
		public InputDeviceCharacteristics characteristics;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x2C")]
		public int deviceId;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x30")]
		public List<XRFeatureDescriptor> inputFeatures;
	}
}
