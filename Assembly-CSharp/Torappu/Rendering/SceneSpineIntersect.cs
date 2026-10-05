using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002069 RID: 8297
	[Token(Token = "0x2002069")]
	public class SceneSpineIntersect : BaseSceneEffect
	{
		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600CC64 RID: 52324 RVA: 0x00049C68 File Offset: 0x00047E68
		[Token(Token = "0x1700183A")]
		private bool intersectEnabled
		{
			[Token(Token = "0x600CC64")]
			[Address(RVA = "0x34E4A60", Offset = "0x34E3660", VA = "0x1834E4A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x00049C80 File Offset: 0x00047E80
		[Token(Token = "0x1700183B")]
		private float intersectHeight
		{
			[Token(Token = "0x600CC65")]
			[Address(RVA = "0x34E4B30", Offset = "0x34E3730", VA = "0x1834E4B30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x0600CC66 RID: 52326 RVA: 0x00049C98 File Offset: 0x00047E98
		[Token(Token = "0x1700183C")]
		private bool hasWaterSurfaceTransform
		{
			[Token(Token = "0x600CC66")]
			[Address(RVA = "0x34E49D0", Offset = "0x34E35D0", VA = "0x1834E49D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC67")]
		[Address(RVA = "0x34E45D0", Offset = "0x34E31D0", VA = "0x1834E45D0", Slot = "11")]
		public override Shader GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC68")]
		[Address(RVA = "0x34E4830", Offset = "0x34E3430", VA = "0x1834E4830")]
		private void Update()
		{
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC69")]
		[Address(RVA = "0x34E46D0", Offset = "0x34E32D0", VA = "0x1834E46D0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6A")]
		[Address(RVA = "0x34E4650", Offset = "0x34E3250", VA = "0x1834E4650", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6B")]
		[Address(RVA = "0x34E4970", Offset = "0x34E3570", VA = "0x1834E4970")]
		public SceneSpineIntersect()
		{
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC6C")]
		[Address(RVA = "0x34D2320", Offset = "0x34D0F20", VA = "0x1834D2320")]
		private Shader <>xLuaBaseProxy_GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6D")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC6E")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D708 RID: 55048
		[Token(Token = "0x400D708")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SceneSpineIntersectProfile _profile;

		// Token: 0x0400D709 RID: 55049
		[Token(Token = "0x400D709")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("hasWaterSurfaceTransform", false)]
		private float _intersectHeight;

		// Token: 0x0400D70A RID: 55050
		[Token(Token = "0x400D70A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _waterSurfaceTransform;

		// Token: 0x0400D70B RID: 55051
		[Token(Token = "0x400D70B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_intersectEnabled;

		// Token: 0x0400D70C RID: 55052
		[Token(Token = "0x400D70C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_intersectHeight;

		// Token: 0x0400D70D RID: 55053
		[Token(Token = "0x400D70D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasWaterSurfaceTransform;

		// Token: 0x0400D70E RID: 55054
		[Token(Token = "0x400D70E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetReplaceSpineShader;

		// Token: 0x0400D70F RID: 55055
		[Token(Token = "0x400D70F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D710 RID: 55056
		[Token(Token = "0x400D710")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D711 RID: 55057
		[Token(Token = "0x400D711")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D712 RID: 55058
		[Token(Token = "0x400D712")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
