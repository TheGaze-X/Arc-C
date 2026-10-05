using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : Object
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x59198B0", Offset = "0x59184B0", VA = "0x1859198B0")]
		private Avatar()
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EA RID: 234
		[Token(Token = "0x17000043")]
		public extern bool isValid { [Token(Token = "0x60000EA")] [Address(RVA = "0x59199F0", Offset = "0x59185F0", VA = "0x1859199F0")] [NativeMethod("IsValid")] [MethodImpl(4096)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EB RID: 235
		[Token(Token = "0x17000044")]
		public extern bool isHuman { [Token(Token = "0x60000EB")] [Address(RVA = "0x59199B0", Offset = "0x59185B0", VA = "0x1859199B0")] [NativeMethod("IsHuman")] [MethodImpl(4096)] get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000045")]
		public HumanDescription humanDescription
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x5919950", Offset = "0x5918550", VA = "0x185919950")]
			get
			{
				return default(HumanDescription);
			}
		}

		// Token: 0x060000ED RID: 237
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5919800", Offset = "0x5918400", VA = "0x185919800")]
		[MethodImpl(4096)]
		internal extern void SetMuscleMinMax(int muscleId, float min, float max);

		// Token: 0x060000EE RID: 238
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5919860", Offset = "0x5918460", VA = "0x185919860")]
		[MethodImpl(4096)]
		internal extern void SetParameter(int parameterId, float value);

		// Token: 0x060000EF RID: 239 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5919020", Offset = "0x5917C20", VA = "0x185919020")]
		internal float GetAxisLength(int humanId)
		{
			return 0f;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x59191D0", Offset = "0x5917DD0", VA = "0x1859191D0")]
		internal Quaternion GetPreRotation(int humanId)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5919130", Offset = "0x5917D30", VA = "0x185919130")]
		internal Quaternion GetPostRotation(int humanId)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5919270", Offset = "0x5917E70", VA = "0x185919270")]
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5919340", Offset = "0x5917F40", VA = "0x185919340")]
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5919090", Offset = "0x5917C90", VA = "0x185919090")]
		internal Vector3 GetLimitSign(int humanId)
		{
			return default(Vector3);
		}

		// Token: 0x060000F5 RID: 245
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5919400", Offset = "0x5918000", VA = "0x185919400")]
		[NativeMethod("GetAxisLength")]
		[MethodImpl(4096)]
		internal extern float Internal_GetAxisLength(int humanId);

		// Token: 0x060000F6 RID: 246 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x59195F0", Offset = "0x59181F0", VA = "0x1859195F0")]
		[NativeMethod("GetPreRotation")]
		internal Quaternion Internal_GetPreRotation(int humanId)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5919540", Offset = "0x5918140", VA = "0x185919540")]
		[NativeMethod("GetPostRotation")]
		internal Quaternion Internal_GetPostRotation(int humanId)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x59196B0", Offset = "0x59182B0", VA = "0x1859196B0")]
		[NativeMethod("GetZYPostQ")]
		internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x5919790", Offset = "0x5918390", VA = "0x185919790")]
		[NativeMethod("GetZYRoll")]
		internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw)
		{
			return default(Quaternion);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5919490", Offset = "0x5918090", VA = "0x185919490")]
		[NativeMethod("GetLimitSign")]
		internal Vector3 Internal_GetLimitSign(int humanId)
		{
			return default(Vector3);
		}

		// Token: 0x060000FB RID: 251
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5919900", Offset = "0x5918500", VA = "0x185919900")]
		[MethodImpl(4096)]
		private extern void get_humanDescription_Injected(out HumanDescription ret);

		// Token: 0x060000FC RID: 252
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x59195A0", Offset = "0x59181A0", VA = "0x1859195A0")]
		[MethodImpl(4096)]
		private extern void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret);

		// Token: 0x060000FD RID: 253
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x59194F0", Offset = "0x59180F0", VA = "0x1859194F0")]
		[MethodImpl(4096)]
		private extern void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret);

		// Token: 0x060000FE RID: 254
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5919650", Offset = "0x5918250", VA = "0x185919650")]
		[MethodImpl(4096)]
		private extern void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret);

		// Token: 0x060000FF RID: 255
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5919730", Offset = "0x5918330", VA = "0x185919730")]
		[MethodImpl(4096)]
		private extern void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret);

		// Token: 0x06000100 RID: 256
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x5919440", Offset = "0x5918040", VA = "0x185919440")]
		[MethodImpl(4096)]
		private extern void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret);
	}
}
