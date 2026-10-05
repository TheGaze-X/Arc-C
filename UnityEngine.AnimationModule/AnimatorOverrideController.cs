using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[UsedByNativeCode]
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x5917940", Offset = "0x5916540", VA = "0x185917940")]
		public AnimatorOverrideController()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x59179D0", Offset = "0x59165D0", VA = "0x1859179D0")]
		public AnimatorOverrideController(RuntimeAnimatorController controller)
		{
		}

		// Token: 0x060000D2 RID: 210
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5917710", Offset = "0x5916310", VA = "0x185917710")]
		[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] AnimatorOverrideController self, RuntimeAnimatorController controller);

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D3 RID: 211
		// (set) Token: 0x060000D4 RID: 212
		[Token(Token = "0x1700003E")]
		public extern RuntimeAnimatorController runtimeAnimatorController { [Token(Token = "0x60000D3")] [Address(RVA = "0x5917D10", Offset = "0x5916910", VA = "0x185917D10")] [NativeMethod("GetAnimatorController")] [MethodImpl(4096)] get; [Token(Token = "0x60000D4")] [Address(RVA = "0x5917E90", Offset = "0x5916A90", VA = "0x185917E90")] [NativeMethod("SetAnimatorController")] [MethodImpl(4096)] set; }

		// Token: 0x1700003F RID: 63
		[Token(Token = "0x1700003F")]
		public AnimationClip this[string name]
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x5917AB0", Offset = "0x59166B0", VA = "0x185917AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x59177C0", Offset = "0x59163C0", VA = "0x1859177C0")]
			set
			{
			}
		}

		// Token: 0x060000D7 RID: 215
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5917760", Offset = "0x5916360", VA = "0x185917760")]
		[NativeMethod("GetClip")]
		[MethodImpl(4096)]
		private extern AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip);

		// Token: 0x060000D8 RID: 216
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x59177C0", Offset = "0x59163C0", VA = "0x1859177C0")]
		[NativeMethod("SetClip")]
		[MethodImpl(4096)]
		private extern void Internal_SetClipByName(string name, AnimationClip clip);

		// Token: 0x17000040 RID: 64
		[Token(Token = "0x17000040")]
		public AnimationClip this[AnimationClip clip]
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x5917A60", Offset = "0x5916660", VA = "0x185917A60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x5917D50", Offset = "0x5916950", VA = "0x185917D50")]
			set
			{
			}
		}

		// Token: 0x060000DB RID: 219
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x59173C0", Offset = "0x5915FC0", VA = "0x1859173C0")]
		[MethodImpl(4096)]
		private extern AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip);

		// Token: 0x060000DC RID: 220
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x59178D0", Offset = "0x59164D0", VA = "0x1859178D0")]
		[MethodImpl(4096)]
		private extern void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify);

		// Token: 0x060000DD RID: 221
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5917890", Offset = "0x5916490", VA = "0x185917890")]
		[MethodImpl(4096)]
		private extern void SendNotification();

		// Token: 0x060000DE RID: 222
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5917420", Offset = "0x5916020", VA = "0x185917420")]
		[MethodImpl(4096)]
		private extern AnimationClip GetOriginalClip(int index);

		// Token: 0x060000DF RID: 223
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5917460", Offset = "0x5916060", VA = "0x185917460")]
		[MethodImpl(4096)]
		private extern AnimationClip GetOverrideClip(AnimationClip originalClip);

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E0 RID: 224
		[Token(Token = "0x17000041")]
		public extern int overridesCount { [Token(Token = "0x60000E0")] [Address(RVA = "0x5917CD0", Offset = "0x59168D0", VA = "0x185917CD0")] [NativeMethod("GetOriginalClipsCount")] [MethodImpl(4096)] get; }

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x59174B0", Offset = "0x59160B0", VA = "0x1859174B0")]
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5917090", Offset = "0x5915C90", VA = "0x185917090")]
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		[Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
		public AnimationClipPair[] clips
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x5917B00", Offset = "0x5916700", VA = "0x185917B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x5917DB0", Offset = "0x59169B0", VA = "0x185917DB0")]
			set
			{
			}
		}

		// Token: 0x060000E5 RID: 229
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5917850", Offset = "0x5916450", VA = "0x185917850")]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		internal extern void PerformOverrideClipListCleanup();

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x5917820", Offset = "0x5916420", VA = "0x185917820")]
		[RequiredByNativeCode]
		[NativeConditional("UNITY_EDITOR")]
		internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000E8 RID: 232
		[Token(Token = "0x2000019")]
		internal delegate void OnOverrideControllerDirtyCallback();
	}
}
