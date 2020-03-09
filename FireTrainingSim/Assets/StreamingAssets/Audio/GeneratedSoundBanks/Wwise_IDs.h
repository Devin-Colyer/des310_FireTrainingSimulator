/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID ALARM = 855317084U;
        static const AkUniqueID LOOSE = 174960569U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX_BOX_DROP = 3205421132U;
        static const AkUniqueID SFX_BOX_HIT = 3773983190U;
        static const AkUniqueID SFX_BOX_HIT_PICKUP = 3049972461U;
        static const AkUniqueID SFX_FOOTSTEP_WALK = 1789744637U;
        static const AkUniqueID TYPE = 2970581085U;
        static const AkUniqueID WIN = 979765101U;
    } // namespace EVENTS

    namespace SWITCHES
    {
        namespace MUSIC
        {
            static const AkUniqueID GROUP = 3991942870U;

            namespace SWITCH
            {
                static const AkUniqueID BOX = 546945280U;
                static const AkUniqueID BOXMINIGAME = 653431367U;
                static const AkUniqueID BOXOUT = 3312932780U;
            } // namespace SWITCH
        } // namespace MUSIC

        namespace SWITCH_FOOTSTEP
        {
            static const AkUniqueID GROUP = 108923538U;

            namespace SWITCH
            {
                static const AkUniqueID CARPET = 2412606308U;
                static const AkUniqueID CONCRETE = 841620460U;
                static const AkUniqueID METAL = 2473969246U;
                static const AkUniqueID VINYL = 3252371007U;
            } // namespace SWITCH
        } // namespace SWITCH_FOOTSTEP

        namespace TYPE
        {
            static const AkUniqueID GROUP = 2970581085U;

            namespace SWITCH
            {
                static const AkUniqueID FAST = 2965380179U;
                static const AkUniqueID NORMAL = 1160234136U;
                static const AkUniqueID SLOW = 787604482U;
            } // namespace SWITCH
        } // namespace TYPE

    } // namespace SWITCHES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID DEFAULT_MOTION_DEVICE = 4230635974U;
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
