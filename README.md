#hada-p1

P1: Se ha subido la rama master.
P2: Se abre una ventana con el código previo a los cambios, señalando las partes modificadas.
P3: No se actualiza el repositorio remoto porque da conflicto, debido a que la rama remota va por delante de la rama local.
P4: Hace commit de todos los cambios en staged -> git commit -m "Mensaje de commit"
P5: Añade todos los cambios al staged y luego hace commit de ellos -> git commit -am "Mensaje para commit"
P6: Hace commit de los archivos staged y push automáticamente -> git commit -m "Mensaje de commit", git push
P7: Sincronizar descarga (y fusiona) los archivos del remoto e inmediatamente después sube los locales -> git pull, git push, git merge ${rama}
    Extraer descarga los archivos, fusionándolos con la rama local, pero no sube los archivos al remoto -> git pull, git merge ${rama}
