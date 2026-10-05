using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002070 RID: 8304
	[Token(Token = "0x2002070")]
	[ExecuteInEditMode]
	public class SpineLightManager : MonoBehaviour
	{
		// Token: 0x0600CC8A RID: 52362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8A")]
		[Address(RVA = "0x34E9FB0", Offset = "0x34E8BB0", VA = "0x1834E9FB0")]
		private void Start()
		{
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8B")]
		[Address(RVA = "0x34EA060", Offset = "0x34E8C60", VA = "0x1834EA060")]
		private void Update()
		{
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8C")]
		[Address(RVA = "0x34E9B10", Offset = "0x34E8710", VA = "0x1834E9B10")]
		private void LightCull(GameObject target, ref Vector4[] LightCol, ref Vector4[] LightPos)
		{
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8D")]
		[Address(RVA = "0x34E9F70", Offset = "0x34E8B70", VA = "0x1834E9F70")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8E")]
		[Address(RVA = "0x34E9F30", Offset = "0x34E8B30", VA = "0x1834E9F30")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x00049CB0 File Offset: 0x00047EB0
		[Token(Token = "0x600CC8F")]
		[Address(RVA = "0x34E99A0", Offset = "0x34E85A0", VA = "0x1834E99A0")]
		private bool IsVisibleFromLight(Light pointLight, Transform objectTransform)
		{
			return default(bool);
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC90")]
		[Address(RVA = "0x34EA330", Offset = "0x34E8F30", VA = "0x1834EA330")]
		public SpineLightManager()
		{
		}

		// Token: 0x0400D78C RID: 55180
		[Token(Token = "0x400D78C")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float lightProbeIntensity;

		// Token: 0x0400D78D RID: 55181
		[Token(Token = "0x400D78D")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float lightProbeColorIntensity;

		// Token: 0x0400D78E RID: 55182
		[Token(Token = "0x400D78E")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 2f)]
		public float lightMax;

		// Token: 0x0400D78F RID: 55183
		[Token(Token = "0x400D78F")]
		[FieldOffset(Offset = "0x28")]
		public List<Light> lightList;

		// Token: 0x0400D790 RID: 55184
		[Token(Token = "0x400D790")]
		[FieldOffset(Offset = "0x30")]
		public List<GameObject> spinelist;

		// Token: 0x0400D791 RID: 55185
		[Token(Token = "0x400D791")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock spineBlock;

		// Token: 0x0400D792 RID: 55186
		[Token(Token = "0x400D792")]
		[FieldOffset(Offset = "0x40")]
		private Vector4[] spineLightCol;

		// Token: 0x0400D793 RID: 55187
		[Token(Token = "0x400D793")]
		[FieldOffset(Offset = "0x48")]
		private Vector4[] spineLightPos;

		// Token: 0x0400D794 RID: 55188
		[Token(Token = "0x400D794")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public Dictionary<GameObject, MeshRenderer> spineDict;
	}
}
