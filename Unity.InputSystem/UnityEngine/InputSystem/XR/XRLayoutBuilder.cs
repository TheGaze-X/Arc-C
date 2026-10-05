using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal class XRLayoutBuilder
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x56B6800", Offset = "0x56B5400", VA = "0x1856B6800")]
		private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor)
		{
			return 0U;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x56B6F20", Offset = "0x56B5B20", VA = "0x1856B6F20")]
		private static string SanitizeString(string original, bool allowPaths = false)
		{
			return null;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x56B6A50", Offset = "0x56B5650", VA = "0x1856B6A50")]
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate)
		{
			return null;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x56B6600", Offset = "0x56B5200", VA = "0x1856B6600")]
		private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias)
		{
			return null;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x56B6A20", Offset = "0x56B5620", VA = "0x1856B6A20")]
		private bool IsSubControl(string name)
		{
			return default(bool);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x56B67C0", Offset = "0x56B53C0", VA = "0x1856B67C0")]
		private string GetParentControlName(string name)
		{
			return null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x56B68C0", Offset = "0x56B54C0", VA = "0x1856B68C0")]
		private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex)
		{
			return default(bool);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x56B5890", Offset = "0x56B4490", VA = "0x1856B5890")]
		private InputControlLayout Build()
		{
			return null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XRLayoutBuilder()
		{
		}

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x10")]
		private string parentLayout;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x18")]
		private string interfaceName;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x20")]
		private XRDeviceDescriptor descriptor;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] poseSubControlNames;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly FeatureType[] poseSubControlTypes;
	}
}
