using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class SampleSelector : MonoBehaviour
{
	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x51BF530", Offset = "0x51BE130", VA = "0x1851BF530")]
	private void Awake()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x51C0DF0", Offset = "0x51BF9F0", VA = "0x1851C0DF0")]
	private void Start()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x51C0E80", Offset = "0x51BFA80", VA = "0x1851C0E80")]
	private void Update()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x51C0760", Offset = "0x51BF360", VA = "0x1851C0760")]
	private void OnGUI()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x51C0670", Offset = "0x51BF270", VA = "0x1851C0670")]
	private void DrawSample(SampleDescriptor sample)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x51C0490", Offset = "0x51BF090", VA = "0x1851C0490")]
	private void DrawSampleDetails(SampleDescriptor sample)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x51C1000", Offset = "0x51BFC00", VA = "0x1851C1000")]
	public SampleSelector()
	{
	}

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	public const int statisticsHeight = 160;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x18")]
	private List<SampleDescriptor> Samples;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x0")]
	public static SampleDescriptor SelectedSample;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 scrollPos;
}
