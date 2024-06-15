# MindComponent localization

comp-mind-ghosting-prevented = Вы не можете стать призраком в данный момент.

## Messages displayed when a body is examined and in a certain state

comp-mind-examined-catatonic = { CAPITALIZE(SUBJECT($ent)) } в кататоническом ступоре. Стрессы жизни в глубоком космосе, должно быть, оказались слишком тяжелы для { OBJECT($ent) }. Восстановление маловероятно.
comp-mind-examined-dead =
    { CAPITALIZE(SUBJECT($ent)) } { GENDER($ent) ->
        [male] мёртв, но мозг ещё активен.
        [female] мертва, но мозг ещё активен.
        [epicene] мертво, но мозг ещё активен.
       *[neuter] мертвы, но мозг ещё активен.
    }
comp-mind-examined-ssd = { CAPITALIZE(SUBJECT($ent)) } рассеяно смотрит в пустоту и ни на что не реагирует. { CAPITALIZE(SUBJECT($ent)) } может скоро придти в себя.
comp-mind-examined-dead-and-ssd = { CAPITALIZE(POSS-ADJ($ent)) } мозг мёртв.
comp-mind-examined-dead-and-irrecoverable = { CAPITALIZE(POSS-ADJ($ent)) } мозг мёртв. Восстановление невозможно.
